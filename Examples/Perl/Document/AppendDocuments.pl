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
use AsposeWordsCloud::Object::DocumentEntryList;
use AsposeWordsCloud::Object::DocumentEntry;

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
my $name =  'SampleWordDocument.docx';
my $document1 =  'SampleWordDocument.docx';
my $document2 =  'SampleWordDocument.docx';

my @docEntry1 = AsposeWordsCloud::Object::DocumentEntry->new('Href' => $document1, 'ImportFormatMode' => 'KeepSourceFormatting');
my @docEntry2 = AsposeWordsCloud::Object::DocumentEntry->new('Href' => $document2, 'ImportFormatMode' => 'KeepSourceFormatting');
my $documentEntryList = AsposeWordsCloud::Object::DocumentEntryList->new('DocumentEntries' => [@docEntry1, @docEntry2]);

# Upload file to aspose cloud storage 
my $response = $storageApi->PutCreate(Path => $name, file => $data_path.$name);
# Invoke Aspose.Words Cloud SDK API to append word document   
$response = $wordsApi->PostAppendDocument(name=> $name, body=> $documentEntryList);

if($response->{'Status'} eq 'OK'){
	print "\nDocuments have been appended successfully";
	# Download appended document from storage server 
	my $output_file = $out_path. 'appended-'.$name;
	$response = $storageApi->GetDownload(Path => $name);;
	write_file($output_file, { binmode => ":raw" }, $response->{'Content'});
}
#ExEnd:1