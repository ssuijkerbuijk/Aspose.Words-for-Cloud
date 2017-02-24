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
my $name = 'SampleBlankWordDocument.docx';
my $image = "aspose-cloud.png";
my $storage = "AsposeDropboxStorage";

# Upload file to aspose cloud storage
my $response = $storageApi->PutCreate(Path => $name, storage=>$storage, file => $data_path.$name);
# Invoke Aspose.Words Cloud SDK API to remove add watermark image in a word document
$response = $wordsApi->PostInsertWatermarkImage(name=> $name, storage=>$storage, file => $data_path.$image);

if($response->{'Status'} eq 'OK'){
	print "\nWatermark image has been added successfully.";
	# Download updated document from storage server
	my $output_file = $out_path.$name;
	$response = $storageApi->GetDownload(Path => $name, storage=>$storage);
	write_file($output_file, { binmode => ":raw" }, $response->{'Content'});
	}
#ExEnd:1