# Aspose.Words Cloud SDK for Perl

This repository contains Aspose.Words Cloud SDK for Perl source code. This SDK allows you to work with Aspose.Words Cloud REST APIs in your Perl applications quickly and easily. 

<p align="center">
  <a title="Download complete Aspose.Words for Cloud source code" href="https://github.com/asposewords/Aspose_Words_Cloud/archive/master.zip">
	<img src="https://raw.github.com/AsposeExamples/java-examples-dashboard/master/images/downloadZip-Button-Large.png" />
  </a>
</p>

## How to use the SDK?

The complete source code is available in this repository folder. For more details, please visit our [documentation website](http://www.aspose.com/docs/display/wordscloud/Available+SDKs).

##Contact Us
Your feedback is very important to us. Please feel free to contact us using our [Support Forums](https://www.aspose.com/community/forums/).

## Quick SDK Tutorial
```javascript

use lib 'lib';
use strict;
use warnings;
use File::Slurp; # From CPAN

use AsposeStorageCloud::StorageApi;
use AsposeStorageCloud::ApiClient;
use AsposeStorageCloud::Configuration;

use AsposeWordsCloud::WordsApi;
use AsposeWordsCloud::ApiClient;
use AsposeWordsCloud::Configuration;

$AsposeWordsCloud::Configuration::app_sid = 'XXX';
$AsposeWordsCloud::Configuration::api_key = 'XXX';

$AsposeStorageCloud::Configuration::app_sid = $AsposeWordsCloud::Configuration::app_sid;
$AsposeStorageCloud::Configuration::api_key = $AsposeWordsCloud::Configuration::api_key;

#Instantiate Aspose.Storage API SDK 
my $storageApi = AsposeStorageCloud::StorageApi->new();

#Instantiate Aspose.Words API SDK
my $wordsApi = AsposeWordsCloud::WordsApi->new();

my $data_path = './data/';

my $filename = 'SampleWordDocument';
my $name = $filename . '.docx';
my $format = 'pdf';

#upload file to aspose cloud storage 
my $response = $storageApi->PutCreate(Path => $name, file => $data_path.$name);

#invoke Aspose.Words Cloud SDK API to convert words document to required format 
$response = $wordsApi->PutConvertDocument(format=> $format, file => $data_path.$name);
	
#download output document from response 
my $output_file = 'C:/temp/'. $filename . '.' . $format;
write_file($output_file, { binmode => ":raw" }, $response->{'Content'});

```
