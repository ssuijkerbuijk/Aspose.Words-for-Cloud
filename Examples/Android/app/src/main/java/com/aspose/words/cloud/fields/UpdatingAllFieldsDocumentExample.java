package com.aspose.words.cloud.fields;

import java.io.File;

import java.io.File; import com.aspose.storage.api.StorageApi; import android.content.Context;
import com.aspose.words.api.WordsApi;
import com.aspose.words.cloud.R;
import com.aspose.words.cloud.Utils;
import com.aspose.words.cloud.config.Configuration;
import com.aspose.words.model.DocumentResponse;

public class UpdatingAllFieldsDocumentExample {

	public static void execute(Context context) throws Exception {
		// ExStart: UpdatingAllFieldsDocumentExample
		try {
			// Instantiate Aspose Storage API SDK
			StorageApi storageApi = new StorageApi(Configuration.apiKey, Configuration.appSID, true);

			// Instantiate Aspose Words API SDK
			WordsApi wordsApi = new WordsApi(Configuration.apiKey, Configuration.appSID, true);

			// set input file name
			String fileName = "SampleWordDocument.docx";
			File input = Utils.stream2file("SampleWordDocument","docx", context.getResources().openRawResource(R.raw.docsample));


			String storage = null;
			String folder = null;

			// upload input file to aspose cloud storage
			storageApi.PutCreate(fileName, "", storage, input);

			// invoke Aspose.Words Cloud SDK API to update fields in the whole
			// document
			DocumentResponse apiResponse = wordsApi.PostUpdateDocumentFields(fileName, fileName, storage, folder);

			if (apiResponse != null && apiResponse.getStatus().equals("OK")) {
				System.out.println("Document fields have been updated successfully");
			}

		} catch (Exception e) {
			e.printStackTrace();
		}
		// ExEnd: UpdatingAllFieldsDocumentExample

	}

}
