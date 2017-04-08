package com.aspose.words.cloud.protection;

import android.content.Context;

import com.aspose.storage.api.StorageApi;
import com.aspose.words.api.WordsApi;
import com.aspose.words.cloud.R;
import com.aspose.words.cloud.Utils;
import com.aspose.words.cloud.config.Configuration;
import com.aspose.words.model.ProtectionDataResponse;
import com.aspose.words.model.ProtectionRequest;

import java.io.File;

public class GetProtectionWordDocumentExample {

	public static void execute(Context context) throws Exception {
		// ExStart: GetProtectionWordDocumentExample

		try {
			// Instantiate Aspose Storage API SDK
			StorageApi storageApi = new StorageApi(Configuration.apiKey, Configuration.appSID, true);

			// Instantiate Aspose Words API SDK
			WordsApi wordsApi = new WordsApi(Configuration.apiKey, Configuration.appSID, true);
			File input = Utils.stream2file("SampleWordDocument","docx", context.getResources().openRawResource(R.raw.sampleworddocument));


			// set input file name
			String fileName = "SampleProtectedBlankWordDocument.docx";
			String destFileName = fileName;
			String storage = null;
			String folder = null;

			// upload input file to aspose cloud storage
			storageApi.PutCreate(fileName, "", "", input);

			// invoke Aspose.Words Cloud SDK API to modify protection of a word
			// document
			ProtectionDataResponse apiResponse = wordsApi.GetDocumentProtection(fileName, storage,
					folder);

			if (apiResponse != null && apiResponse.getStatus().equals("OK")) {

				System.out.println(
						"Get Document protection completed successfully");
			}

		} catch (Exception e) {
			e.printStackTrace();
		}
		// ExEnd: GetProtectionWordDocumentExample

	}

}
