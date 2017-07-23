package com.aspose.words.cloud.text;

import java.nio.file.Path;

import com.aspose.storage.api.StorageApi;
import com.aspose.words.api.WordsApi;
import com.aspose.words.cloud.config.Configuration;
import com.aspose.words.cloud.config.Utils;
import com.aspose.words.model.ReplaceTextRequest;
import com.aspose.words.model.TextItem;
import com.aspose.words.model.TextItemsResponse;

public class GetDocumentTextItemsExample {

    public static void main(String[] args) {
        //ExStart: 1
     // Instantiate Aspose Storage API SDK
        StorageApi storageApi = new StorageApi(Configuration.apiKey, Configuration.appSID, true);
        // Instantiate Aspose Words API SDK
        WordsApi wordsApi = new WordsApi(Configuration.apiKey, Configuration.appSID, true);

        String fileName = "SampleWordDocument.docx";
        String storage = null;
        String folder = null;

       
        Path p1=Utils.getPath(GetDocumentTextItemsExample.class, fileName);
        

        try
        {
            // Upload the file
            storageApi.PutCreate(fileName, "", "", p1.toFile());
            // Invoke Aspose.Words Cloud SDK API to replace text 
            TextItemsResponse apiResponse = wordsApi.GetDocumentTextItems(fileName, storage, folder);

            if (apiResponse != null && apiResponse.getStatus().equals("OK"))
            {   
                System.out.println("Text replaced successfully");
                for(TextItem t : apiResponse.getTextItems().getList()){
                	System.out.println(t.getText());
                }
                
                
            }
        }
        catch (Exception ex)
        {
            ex.printStackTrace();
        }
       //ExEnd: 1
    }

}
