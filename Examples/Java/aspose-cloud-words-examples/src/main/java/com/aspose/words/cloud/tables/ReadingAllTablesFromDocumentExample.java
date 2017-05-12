package com.aspose.words.cloud.tables;

import java.nio.file.Path;

import com.aspose.storage.api.StorageApi;
import com.aspose.words.api.WordsApi;
import com.aspose.words.cloud.config.Configuration;
import com.aspose.words.cloud.config.Utils;
import com.aspose.words.model.TableLinkCollectionResponse;

public class ReadingAllTablesFromDocumentExample {

	public static void main(String[] args) {
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
			
			Path path=Utils.getPath(ReadingAllTablesFromDocumentExample.class, fileName);

			// upload input file to aspose cloud storage
			storageApi.PutCreate(fileName, "", "",path.toFile());

			//Invoke the API
			TableLinkCollectionResponse apiResponse = wordsApi.GetTables("TableDocument.doc", "tables/1/rows/0/borders", storage, folder);

			if (apiResponse != null && apiResponse.getStatus().equals("OK")) {

				System.out.println("Reading Table Information Done");
			}
            
		} catch (Exception e) {
			e.printStackTrace();
		}
		// ExEnd: 1

	}

}
