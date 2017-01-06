package com.aspose.words.cloud.mailmerge;

import java.io.File;
import java.io.InputStream;
import java.nio.file.Files;
import java.nio.file.Path;
import java.nio.file.Paths;
import java.nio.file.StandardCopyOption;

import com.aspose.storage.api.StorageApi;
import com.aspose.words.api.WordsApi;
import com.aspose.words.cloud.config.Configuration;
import com.aspose.words.model.DocumentResponse;

public class ExecuteMailMergeTemplateExample {

	public static void main(String[] args) {
		try {
            // Instantiate Aspose Storage API SDK
            StorageApi storageApi = new StorageApi(Configuration.apiKey, Configuration.appSID, true);

            // Instantiate Aspose Words API SDK
            WordsApi wordsApi = new WordsApi(Configuration.apiKey, Configuration.appSID, true);

            // set input file name
            String fileName = "SampleExecuteTemplate.docx";

            String cleanup = null;
            String destFileName = "updated-" + fileName;
            String storage = null;
            String folder = null;
            Boolean useWholeParagraphAsRegion = null;
            Boolean withRegions = null;
            File file;




           //upload input file to aspose cloud storage
           storageApi.PutCreate(fileName, "", "", new File(ExecuteMailMergeTemplateExample.class.getResource("/" + fileName).toURI()));

           // set input file data name
           String fileDataName = "SampleExecuteTemplateData.txt";

           file = new File(ExecuteMailMergeTemplateExample.class.getResource("/" + fileDataName).toURI());

            // invoke Aspose.Words Cloud SDK API to execute mail merge template and populate a word document from XML data
            DocumentResponse apiResponse = wordsApi
                            .PostExecuteTemplate(
                                            fileName,
                                            cleanup,
                                            destFileName,
                                            storage,
                                            folder,
                                            useWholeParagraphAsRegion,
                                            withRegions, file);

            if (apiResponse != null
                            && apiResponse.getStatus().equals("OK")) {

                    System.out.println("mail merge template has been executed successfully");

                    // download updated file from cloud storage
                    com.aspose.storage.model.ResponseMessage storageRes = storageApi
                                    .GetDownload(destFileName,
                                                    null, null);

                    InputStream responseStream = storageRes.getInputStream();

                    final Path destination = Paths.get("c:\\temp\\" + destFileName);

                    Files.copy(responseStream,destination,StandardCopyOption.REPLACE_EXISTING);

            }

    } catch (Exception e) {
            e.printStackTrace();
    }

	}

}
