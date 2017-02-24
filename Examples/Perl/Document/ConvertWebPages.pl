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
use AsposeWordsCloud::Object::SaveOptionsData;
use AsposeWordsCloud::Object::LoadWebDocumentData;

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
my $filename = 'WebPageConverterExample.doc';
my $saveOptionsData = AsposeWordsCloud::Object::SaveOptionsData->new('SaveFormat' => 'doc', 'FileName' => $filename);
my $loadWebDocumentData = AsposeWordsCloud::Object::LoadWebDocumentData->new('LoadingDocumentUrl' => 'http://google.com', 'SaveOptions' => $saveOptionsData);	
# Invoke Aspose.Words Cloud SDK API to convert live web page into words document       
my $response = $wordsApi->PostLoadWebDocument(body => $loadWebDocumentData);
if($response->{'Status'} eq 'OK'){
	print "\nDocument has been generated successfully";
	# Download output document from storage server 
	my $output_file = $filename;
	$response = $storageApi->GetDownload(Path => $output_file);	
	write_file($out_path.$output_file, { binmode => ":raw" }, $response->{'Content'});
	}
#ExEnd:1