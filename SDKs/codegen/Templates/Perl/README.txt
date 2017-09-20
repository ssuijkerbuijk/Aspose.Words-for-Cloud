Step to generate aspose cloud perl autogen sdks

1. Please use 'templates-aspose-perl' to generate 'Object' model using 'swagger-codegen-2.1.3'

java -jar modules/swagger-codegen-cli/target/swagger-codegen-cli.jar generate -t templates-aspose-perl -i http://localhost:8080/asposesdk/storage/ -l perl -o samples/client/asposesdks/aspose-cloud-storage-perl -c templates-aspose-perl/perl-config.json


2. Please use 'SwaggerAutoGemTemplate' to generate 'ProductApi.pm'. You have to set language to Node.js to generate it. I am using swagger-codegne-2.1.2-M1 for this purpose. 

java -jar modules/swagger-codegen-distribution/target/swagger-codegen-distribution-2.1.2-M1.jar generate -t SwaggerAutoGemTemplate -i http://localhost:8080/asposesdk/words/ -l nodejs -o samples/client/asposesdks/aspose-words-cloud-perl
