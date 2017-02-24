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
use AsposeWordsCloud::Object::PageSetup;

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
my $sectionIndex = 0;

my $pageSetup = AsposeWordsCloud::Object::PageSetup->new(
 'RtlGutter' => 'True',
 'LeftMargin' => 10.0,
 'Orientation' => 'Landscape',
 'PaperSize' => 'A5'
);
# Upload file to aspose cloud storage
my $response = $storageApi->PutCreate(Path => $name, file => $data_path.$name);
# Invoke Aspose.Words Cloud SDK API to update page setup properties by given section index from a word document
$response = $wordsApi->UpdateSectionPageSetup(name=> $name, sectionIndex=>$sectionIndex, body=>$pageSetup);
if($response->{'Status'} eq 'OK'){
	my $secPageSetup = $response->{'PageSetup'};
	print "\nPaperSize : " . $secPageSetup->{'PaperSize'} . " Orientation: " . $secPageSetup->{'Orientation'};
}
#ExEnd:1