#ExStart:1
use lib 'lib';
use strict;
use warnings;
use utf8;
use File::Slurp; # From CPAN
use JSON;

use AsposeStorageCloud::StorageApi;
use AsposeStorageCloud::ApiClient;
use AsposeStorageCloud::Configuration;
use AsposeWordsCloud::WordsApi;
use AsposeWordsCloud::ApiClient;
use AsposeWordsCloud::Configuration;

my $configFile = '../Config/config.json';
my $configPropsText = read_file($configFile);
my $configProps = decode_json($configPropsText);
my $data_path = '../../../Data/';
my $out_path = $configProps->{'out_folder'};

$AsposeWordsCloud::Configuration::app_sid = $configProps->{'app_sid'};
$AsposeWordsCloud::Configuration::api_key = $configProps->{'api_key'};
$AsposeWordsCloud::Configuration::debug = 1;
$AsposeStorageCloud::Configuration::app_sid = $configProps->{'app_sid'};
$AsposeStorageCloud::Configuration::api_key = $configProps->{'api_key'};

# Instantiate Aspose.Storage and Aspose.Words API SDK
my $storageApi = AsposeStorageCloud::StorageApi->new();
my $wordsApi = AsposeWordsCloud::WordsApi->new();

# Set input file name
my $name = 'SampleWordDocument.docx';
my $format = 'png';
my $from = 1;
my $to = 2;
my $zipOutput = 'False';

# Upload file to aspose cloud storage 
my $response = $storageApi->PutCreate(Path => $name, file => $data_path.$name);
# Invoke Aspose.Words Cloud SDK API to split word document     
$response = $wordsApi->PostSplitDocument(name=> $name, format=>$format, from=>$from, to=>$to, zipOutput=>$zipOutput);

if($response->{'Status'} eq 'OK'){
	print "\nDocument has been splitted to png successfully";
	# Download splitted png from storage server 
	my $output_file = @{$response->{'SplitResult'}->{'Pages'}}[0]->{'Href'};
	$response = $storageApi->GetDownload(Path => $output_file);	
	write_file($out_path.$output_file, { binmode => ":raw" }, $response->{'Content'});
	}
#ExEnd:1