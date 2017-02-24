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
use AsposeWordsCloud::Object::DocumentProperty;

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
my $propertyName = 'Author';

# Upload file to aspose cloud storage 
my $response = $storageApi->PutCreate(Path => $name, file => $data_path.$name);
my $propertyBody = AsposeWordsCloud::Object::DocumentProperty->new( 'Name' => 'Author', 'Value' => 'Naeem Akram');
# Invoke Aspose.Words Cloud SDK API to update document property by given name from a word document                   
$response = $wordsApi->PutUpdateDocumentProperty(name=> $name, propertyName=>$propertyName, body=>$propertyBody);
if($response->{'Status'} eq 'OK'){
	my $docProperty = $response->{'DocumentProperty'};
	# Display document property info
    print "\n $docProperty->{'Name'}" . " : " . $docProperty->{'Value'};
}
#ExEnd:1