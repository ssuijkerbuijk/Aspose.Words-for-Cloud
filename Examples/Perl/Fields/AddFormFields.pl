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
use AsposeWordsCloud::Object::BookmarkData;

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
my $sectionIndex = 0;
my $paragraphIndex = 0;
my $insertBeforeNode = "";

my $xmlBody = '<FormFieldTextInput>'
            . '<Name>MyName</Name>'
            . '<Enabled>true</Enabled>'
            . '<StatusText />'
            . '<OwnStatus>false</OwnStatus>'
            . '<HelpText />'
            . '<OwnHelp>false</OwnHelp>'
            . '<CalculateOnExit>true</CalculateOnExit>'
            . '<EntryMacro />'
            . '<ExitMacro />'
            . '<TextInputFormat>UPPERCASE</TextInputFormat>'
            . '<TextInputType>Regular</TextInputType>'
            . '<TextInputDefault>Farooq Sheikh</TextInputDefault>'
            . '</FormFieldTextInput>';

# Upload file to aspose cloud storage 
my $response = $storageApi->PutCreate(Path => $name, file => $data_path.$name);

my $bookmarkDataBody = AsposeWordsCloud::Object::BookmarkData->new( 'Name' => 'aspose', 'Text' => 'Bookmark is very good');

# Invoke Aspose.Words Cloud SDK API to add field in the document     
	$response = $wordsApi->PutFormField(name=> $name, sectionIndex=>$sectionIndex, 
										paragraphIndex=>$paragraphIndex, insertBeforeNode=>$insertBeforeNode, body=>$xmlBody);

if($response->{'Status'} eq 'OK'){
	my $bookmark = $response->{'Bookmark'};
	# Download updated document from storage server
	$response = $storageApi->GetDownload(Path => $name);
	my $output_file = 'updated-' . $name;	
	write_file($out_path.$output_file, { binmode => ":raw" }, $response->{'Content'});
	}
#ExEnd:1