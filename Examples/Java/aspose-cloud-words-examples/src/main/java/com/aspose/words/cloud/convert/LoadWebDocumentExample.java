package com.aspose.words.cloud.convert;

import com.aspose.storage.api.StorageApi;
import com.aspose.words.api.WordsApi;
import com.aspose.words.cloud.config.Configuration;
import com.aspose.words.model.LoadWebDocumentData;
import com.aspose.words.model.SaveOptions;
import com.aspose.words.model.SaveResponse;

public class LoadWebDocumentExample {

    public static void main(String[] args) {
        // ExStart: 1
        try {
            // Instantiate Aspose Storage API SDK
            StorageApi storageApi = new StorageApi(Configuration.apiKey, Configuration.appSID, true);

            // Instantiate Aspose Words API SDK
            WordsApi wordsApi = new WordsApi(Configuration.apiKey, Configuration.appSID, true);


            SaveOptions saveOptionsData = new SaveOptions();
            saveOptionsData.setFileName("");
            saveOptionsData.setSaveFormat("doc");

            LoadWebDocumentData loadOtion = new LoadWebDocumentData();
            loadOtion.setLoadingDocumentUrl("http://www.aspose.com/corporate/default.aspx");
            loadOtion.setSaveOptions(saveOptionsData);

            // invoke Aspose.Words Cloud SDK API
            SaveResponse apiResponse = wordsApi.PostLoadWebDocument(loadOtion);

            if (apiResponse != null && apiResponse.getStatus().equals("OK")) {
                System.out.println("OK");
            }

        } catch (Exception e) {
            e.printStackTrace();
        }
        // ExEnd: 1

    }

}
