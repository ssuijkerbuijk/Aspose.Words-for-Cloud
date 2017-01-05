package com.aspose.words.cloud.headersfooters;

import java.io.File;
import java.io.InputStream;
import java.nio.file.Files;
import java.nio.file.Path;
import java.nio.file.Paths;
import java.nio.file.StandardCopyOption;

import com.aspose.storage.api.StorageApi;
import com.aspose.words.api.WordsApi;
import com.aspose.words.cloud.config.Configuration;
import com.aspose.words.model.SaaSposeResponse;

public class RemovingHeaderFootersDocumentExample {

	public static void main(String[] args) {
		   try {
               // Instantiate Aspose Storage API SDK
               StorageApi storageApi = new StorageApi(Configuration.apiKey, Configuration.appSID, true);

               // Instantiate Aspose Words API SDK
               WordsApi wordsApi = new WordsApi(Configuration.apiKey, Configuration.appSID, true);

               // set input file name
               String fileName = "SampleHeaderFooterWordDocument.docx";

               String destFileName = "updated-" + fileName;
               String headersFootersTypes = null;
               String storage = null;
               String folder = null;

               //upload input file to aspose cloud storage
               storageApi.PutCreate(fileName, "", "", new File(RemovingHeaderFootersDocumentExample.class.getResource("/" + fileName).toURI()));

               // invoke Aspose.Words Cloud SDK API to remove all headers and footers from a word document
               SaaSposeResponse apiResponse = wordsApi.DeleteHeadersFooters(fileName, headersFootersTypes, destFileName, storage, folder);

               if (apiResponse != null
                               && apiResponse.getStatus().equals("OK")) {

                       System.out.println("All headers and footers have been deleted successfully");

                       // download updated file from cloud storage
                       com.aspose.storage.model.ResponseMessage storageRes = storageApi
                                       .GetDownload(destFileName,
                                                       null, null);

                       InputStream responseStream = storageRes.getInputStream();

                       final Path destination = Paths.get(destFileName);

                       Files.copy(responseStream,destination,StandardCopyOption.REPLACE_EXISTING);

               }

       } catch (Exception e) {
               e.printStackTrace();
       }

	}

}
