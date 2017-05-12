package com.aspose.words.cloud.text;

import java.nio.file.Path;
import com.aspose.storage.api.StorageApi;
import com.aspose.words.api.WordsApi;
import com.aspose.words.cloud.config.Configuration;
import com.aspose.words.cloud.config.Utils;
import com.aspose.words.model.ReplaceTextRequest;
import com.aspose.words.model.ReplaceTextResponse;

public class FindReplaceTextExample {

    public static void main(String[] args) {
        //ExStart: 1
     // Instantiate Aspose Storage API SDK
        StorageApi storageApi = new StorageApi(Configuration.apiKey, Configuration.appSID, true);
        // Instantiate Aspose Words API SDK
        WordsApi wordsApi = new WordsApi(Configuration.apiKey, Configuration.appSID, true);

        String fileName = "SampleWordDocument.docx";
        String storage = null;
        String folder = null;

        ReplaceTextRequest body = new ReplaceTextRequest();
        body.setOldValue ("aspose");
        body.setNewValue ( "aspose.com");
        Path p1=Utils.getPath(FindReplaceTextExample.class, fileName);
        
        String revisionDateTime = "2017-02-20";
        String revisionAuthor = "Mateen";

        try
        {
            // Upload the file
            storageApi.PutCreate(fileName, "", "", p1.toFile());
            // Invoke Aspose.Words Cloud SDK API to replace text 
            ReplaceTextResponse apiResponse = wordsApi.PostReplaceText(fileName, fileName, storage, folder, body,revisionAuthor,revisionDateTime);

            if (apiResponse != null && apiResponse.getStatus().equals("OK"))
            {   
                System.out.println("Text replaced successfully");
            }
        }
        catch (Exception ex)
        {
            ex.printStackTrace();
        }
       //ExEnd: 1
    }

}
