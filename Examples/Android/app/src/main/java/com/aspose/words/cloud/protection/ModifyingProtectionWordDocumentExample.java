package com.aspose.words.cloud.protection;

import java.io.File;
import java.io.InputStream;





import java.io.File; import com.aspose.storage.api.StorageApi; import android.content.Context;
import com.aspose.words.api.WordsApi;
import com.aspose.words.cloud.R;
import com.aspose.words.cloud.Utils;
import com.aspose.words.cloud.config.Configuration;
import com.aspose.words.model.ProtectionDataResponse;
import com.aspose.words.model.ProtectionRequest;

public class ModifyingProtectionWordDocumentExample {

	public static void execute(Context context) throws Exception {
		// ExStart: ModifyingProtectionWordDocumentExample

		try {
			// Instantiate Aspose Storage API SDK
			StorageApi storageApi = new StorageApi(Configuration.apiKey, Configuration.appSID, true);

			// Instantiate Aspose Words API SDK
			WordsApi wordsApi = new WordsApi(Configuration.apiKey, Configuration.appSID, true);
			File input = Utils.stream2file("SampleWordDocument","docx", context.getResources().openRawResource(R.raw.docsample));


			// set input file name
			String fileName = "SampleProtectedBlankWordDocument.docx";
			String destFileName = fileName;
			String storage = null;
			String folder = null;

			ProtectionRequest body = new ProtectionRequest();
			body.setPassword("aspose");
			body.setNewPassword("");
			body.setProtectionType("NoProtection");

			// upload input file to aspose cloud storage
			storageApi.PutCreate(fileName, "", "", input);

			// invoke Aspose.Words Cloud SDK API to modify protection of a word
			// document
			ProtectionDataResponse apiResponse = wordsApi.PostChangeDocumentProtection(fileName, destFileName, storage,
					folder, body);

			if (apiResponse != null && apiResponse.getStatus().equals("OK")) {

				System.out.println(
						"Document protection property has been changed from protected to unprotected successfully");
			}

		} catch (Exception e) {
			e.printStackTrace();
		}
		// ExEnd: ModifyingProtectionWordDocumentExample

	}

}
