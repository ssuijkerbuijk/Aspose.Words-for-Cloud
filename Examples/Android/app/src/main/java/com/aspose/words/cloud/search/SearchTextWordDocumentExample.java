package com.aspose.words.cloud.search;

import android.content.Context;
import java.io.File;
import com.aspose.storage.api.StorageApi;
import com.aspose.words.api.WordsApi;
import com.aspose.words.cloud.R;
import com.aspose.words.cloud.Utils;
import com.aspose.words.cloud.config.Configuration;
import com.aspose.words.model.SearchResult;

public class SearchTextWordDocumentExample {

	public static void execute(Context context) throws Exception   {
		// ExStart: 1
		try {
			// Instantiate Aspose Storage API SDK
			StorageApi storageApi = new StorageApi(Configuration.apiKey, Configuration.appSID, true);

			// Instantiate Aspose Words API SDK
			WordsApi wordsApi = new WordsApi(Configuration.apiKey, Configuration.appSID, true);

			// set input file name
			String fileName = "SampleWordDocument.docx";
			String storage = null;
			String folder = null;

			File input = Utils.stream2file("SampleWordDocument","docx", context.getResources().openRawResource(R.raw.sampleexecutetemplate));
	

			// upload input file to aspose cloud storage
			storageApi.PutCreate(fileName, "", "",input);

			// invoke Aspose.Words Cloud SDK API
			SearchResult apiResponse = wordsApi.Search(fileName,"abc", storage, folder);

			if (apiResponse != null && apiResponse.getStatus().equals("OK")) {

				System.out.println("Search Result Example Done");
			}
            
		} catch (Exception e) {
			e.printStackTrace();
		}
		// ExEnd: 1

	}

}
