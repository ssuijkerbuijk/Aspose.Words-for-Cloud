package com.aspose.words.cloud.tables;

import android.content.Context;

import java.io.File;
import com.aspose.storage.api.StorageApi;
import com.aspose.words.api.WordsApi;
import com.aspose.words.cloud.R;
import com.aspose.words.cloud.Utils;
import com.aspose.words.cloud.config.Configuration;
import com.aspose.words.model.SaaSposeResponse;

public class DeletingTablesFromDocumentExample {

	public static void execute(Context context) throws Exception  {
		// ExStart: 1
		try {
			// Instantiate Aspose Storage API SDK
			StorageApi storageApi = new StorageApi(Configuration.apiKey, Configuration.appSID, true);

			// Instantiate Aspose Words API SDK
			WordsApi wordsApi = new WordsApi(Configuration.apiKey, Configuration.appSID, true);

			// set input file name
			String fileName = "TableDocument.doc";
			String storage = null;
			String folder = null;

			File input = Utils.stream2file("TableDocument","docx", context.getResources().openRawResource(R.raw.tabledocument));

			// upload input file to aspose cloud storage
			storageApi.PutCreate(fileName, "", "",input);

			//Invoke the API
			SaaSposeResponse apiResponse = wordsApi.DeleteTable("TableDocument.doc", "tables/1", storage, folder);

			if (apiResponse != null && apiResponse.getStatus().equals("OK")) {

				System.out.println("Table deleted from Word Document");
			}
            
		} catch (Exception e) {
			e.printStackTrace();
		}
		// ExEnd: 1

	}

}
