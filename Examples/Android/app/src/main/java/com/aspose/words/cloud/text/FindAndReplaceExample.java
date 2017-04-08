package com.aspose.words.cloud.text;

import android.content.Context;
import com.aspose.storage.api.StorageApi;
import com.aspose.words.api.WordsApi;
import com.aspose.words.cloud.R;
import com.aspose.words.cloud.Utils;
import com.aspose.words.cloud.config.Configuration;
import com.aspose.words.model.Bookmark;
import com.aspose.words.model.BookmarksResponse;
import com.aspose.words.model.ReplaceTextRequest;
import com.aspose.words.model.ReplaceTextResponse;

import java.io.File;

public class FindAndReplaceExample {

	public static void execute(Context context) throws Exception {
		// ExStart: FindAndReplaceExample
		String fileName = "SampleWordDocument.docx";
		String storage = null;
		String folder = null;
		ReplaceTextRequest body = new ReplaceTextRequest();
		body.setOldValue ("aspose");
		body.setNewValue ( "aspose.com");
		try {
			// Instantiate Aspose Storage API SDK
			StorageApi storageApi = new StorageApi(Configuration.apiKey, Configuration.appSID, true);

			// Instantiate Aspose Words API SDK
			WordsApi wordsApi = new WordsApi(Configuration.apiKey, Configuration.appSID, true);

			File input = Utils.stream2file("SampleWordDocument","docx", context.getResources().openRawResource(R.raw.sampleworddocument));

			// upload input file to aspose cloud storage
			storageApi.PutCreate(fileName, "", "", input);

			// invoke Aspose.Words Cloud SDK API to get all the bookmarks from a
			// word document
			ReplaceTextResponse apiResponse = wordsApi.PostReplaceText(fileName, fileName, storage, folder, body);

			if (apiResponse != null && apiResponse.getStatus().equals("OK")) {

				System.out.println("Text replaced successfully");
			}

		} catch (Exception e) {
			e.printStackTrace();
		}
		// ExEnd: FindAndReplaceExample

	}

}
