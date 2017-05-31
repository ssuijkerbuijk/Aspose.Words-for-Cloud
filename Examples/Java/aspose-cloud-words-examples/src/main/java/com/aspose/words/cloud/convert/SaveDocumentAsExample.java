package com.aspose.words.cloud.convert;

import java.nio.file.Path;

import com.aspose.storage.api.StorageApi;
import com.aspose.words.api.WordsApi;
import com.aspose.words.cloud.config.Configuration;
import com.aspose.words.cloud.config.Utils;
import com.aspose.words.model.SaveOptions;
import com.aspose.words.model.SaveResponse;

public class SaveDocumentAsExample {

    public static void main(String[] args) {
        // ExStart: 1
        try {
            // Instantiate Aspose Storage API SDK
            StorageApi storageApi = new StorageApi(Configuration.apiKey, Configuration.appSID, true);

            // Instantiate Aspose Words API SDK
            WordsApi wordsApi = new WordsApi(Configuration.apiKey, Configuration.appSID, true);

            // set destination file name
            String fileName = "MathsObject.docx";

            Path p1=Utils.getPath(SaveDocumentAsExample.class, fileName);

            SaveOptions saveOptions = new SaveOptions();
            saveOptions.setSaveFormat("bmp");
            saveOptions.setFileName("Data.bmp");
            saveOptions.setHorizontalResolution(700);
            saveOptions.setVerticleResolution(400);

            // upload source file to Aspose cloud storage
            storageApi.PutCreate(fileName, "", "", p1.toFile());

            // invoke Aspose.Words Cloud SDK API
            SaveResponse apiResponse = wordsApi.PostDocumentSaveAs(fileName, null, null, saveOptions);

            if (apiResponse != null && apiResponse.getStatus().equals("OK")) {
                System.out.println("OK");
            }

        } catch (Exception e) {
            e.printStackTrace();
        }
        // ExEnd: 1

    }

}
