#ExStart:1
use lib 'lib';
use strict;
use warnings;
use utf8;
use File::Slurp; # From CPAN
use JSON;

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

my $wordsApi = AsposeWordsCloud::WordsApi->new();

# Set input file name
my $name =  'SampleMailMergeTemplate.docx';
my $filedataname = "SampleMailMergeTemplateData.txt";
my $destfilename = "updated-" . $name;

# Invoke Aspose.Words Cloud SDK API to execute mail merge online and populate a word document from XML data      
my $response = $wordsApi->PutExecuteMailMergeOnline(withRegions => 'False', file => $data_path.$name, data=>$data_path.$filedataname);

if($response->{'Status'} eq 'OK'){
	print "\nmail merge online template has been executed successfully.";
	# Download updated document from response
	my $output_file = $out_path. $destfilename;	
	write_file($output_file, { binmode => ":raw" }, $response->{'Content'});
	}
#ExEnd:1