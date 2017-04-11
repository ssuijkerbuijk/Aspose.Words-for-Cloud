package com.aspose.words.cloud.watermarks;

import java.io.File;


import com.aspose.storage.api.StorageApi; import android.content.Context;
import com.aspose.words.api.WordsApi;
import com.aspose.words.cloud.R;
import com.aspose.words.cloud.Utils;
import com.aspose.words.cloud.config.Configuration;
import com.aspose.words.model.DocumentResponse;

public class RemoveWaterMarkTextFromDocumentExample {

	public static void execute(Context context) throws Exception {
		// ExStart: RemoveWaterMarkTextFromDocumentExample

		try {
			// Instantiate Aspose Storage API SDK
			StorageApi storageApi = new StorageApi(Configuration.apiKey, Configuration.appSID, true);

			// Instantiate Aspose Words API SDK
			WordsApi wordsApi = new WordsApi(Configuration.apiKey, Configuration.appSID, true);

			// set input file name
			String fileName = "SampleWordDocument.docx";
			String destFileName = "updated-" + fileName;
			String storage = null;
			String folder = null;

			File input = Utils.stream2file("SampleWordDocument","docx", context.getResources().openRawResource(R.raw.docsample));

			// upload input file to aspose cloud storage
			storageApi.PutCreate(fileName, "", "", input);

			// invoke Aspose.Words Cloud SDK API to remove watermark image from
			// a word document
			DocumentResponse apiResponse = wordsApi.DeleteDocumentWatermark(fileName, destFileName, storage, folder);

			if (apiResponse != null && apiResponse.getStatus().equals("OK")) {

				System.out.println("Watermark image has been removed successfully");
			}

		} catch (Exception e) {
			e.printStackTrace();
		}
		// ExEnd: RemoveWaterMarkTextFromDocumentExample
	}

}
