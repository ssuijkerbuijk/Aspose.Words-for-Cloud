package com.aspose.words.cloud.protection;

import java.io.File;
import java.io.InputStream;
import java.nio.file.Files;
import java.nio.file.Path;
import java.nio.file.Paths;
import java.nio.file.StandardCopyOption;

import com.aspose.storage.api.StorageApi;
import com.aspose.words.api.WordsApi;
import com.aspose.words.cloud.config.Configuration;
import com.aspose.words.model.ProtectionDataResponse;
import com.aspose.words.model.ProtectionRequest;

public class RemovingProtectionWordDocumentExample {

	public static void main(String[] args) {
		try {
            // Instantiate Aspose Storage API SDK
            StorageApi storageApi = new StorageApi(Configuration.apiKey, Configuration.appSID, true);

            // Instantiate Aspose Words API SDK
            WordsApi wordsApi = new WordsApi(Configuration.apiKey, Configuration.appSID, true);

            // set input file name
            String fileName = "SampleProtectedBlankWordDocument.docx";
            String destFileName = fileName;
            String storage = null;
            String folder = null;

            ProtectionRequest body = new ProtectionRequest();
            body.setPassword("aspose");

            //upload input file to aspose cloud storage
            storageApi.PutCreate(fileName, "", "", new File(RemovingProtectionWordDocumentExample.class.getResource("/" + fileName).toURI()));

            // invoke Aspose.Words Cloud SDK API to unprotect a word document
            ProtectionDataResponse apiResponse = wordsApi.DeleteUnprotectDocument(fileName, destFileName, storage, folder, body);

            if (apiResponse != null
                            && apiResponse.getStatus().equals("OK")) {

                    System.out.println("Document has been unprotected successfully");

                    // download updated file from cloud storage
                    com.aspose.storage.model.ResponseMessage storageRes = storageApi
                                    .GetDownload(destFileName,
                                                    null, null);

                    InputStream responseStream = storageRes.getInputStream();

                    final Path destination = Paths.get( destFileName);

                    Files.copy(responseStream,destination,StandardCopyOption.REPLACE_EXISTING);
            }

    } catch (Exception e) {
            e.printStackTrace();
    }

	}

}
