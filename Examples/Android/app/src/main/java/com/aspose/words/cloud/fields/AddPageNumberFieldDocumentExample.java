package com.aspose.words.cloud.fields;

import java.io.File;
import java.io.InputStream;





import java.io.File; import com.aspose.storage.api.StorageApi; import android.content.Context;
import com.aspose.words.api.WordsApi;
import com.aspose.words.cloud.R;
import com.aspose.words.cloud.Utils;
import com.aspose.words.cloud.config.Configuration;
import com.aspose.words.model.DocumentResponse;
import com.aspose.words.model.PageNumber;

public class AddPageNumberFieldDocumentExample {

	public static void execute(Context context) throws Exception {
		// ExStart: AddPageNumberFieldDocumentExample
		try {
			// Instantiate Aspose Storage API SDK
			StorageApi storageApi = new StorageApi(Configuration.apiKey, Configuration.appSID, true);

			// Instantiate Aspose Words API SDK
			WordsApi wordsApi = new WordsApi(Configuration.apiKey, Configuration.appSID, true);

			// set input file name
			String fileName = "SampleWordDocument.docx";

			String storage = null;
			String folder = null;
			File input = Utils.stream2file("SampleWordDocument","docx", context.getResources().openRawResource(R.raw.SampleWordDocument));

			PageNumber body = new PageNumber();
			body.setFormat("{PAGE} of {NUMPAGES}");
			body.setAlignment("center");

			// upload input file to aspose cloud storage
			storageApi.PutCreate(fileName, "", "", input);

			// invoke Aspose.Words Cloud SDK API to insert page number field
			// into a word document
			DocumentResponse apiResponse = wordsApi.PostInsertPageNumbers(fileName, fileName, storage, folder, body);

			if (apiResponse != null && apiResponse.getStatus().equals("OK")) {
				System.out.println("Page Number Field has been inserted successfully");
				// download updated file from cloud storage
				com.aspose.storage.model.ResponseMessage storageRes = storageApi.GetDownload(fileName, null, null);
				InputStream responseStream = storageRes.getInputStream();
				File desination=Utils.createTempFile("temp1234", ".docx");
				Utils.copyInputStreamToFile(storageRes.getInputStream(),desination);
			}

		} catch (Exception e) {
			e.printStackTrace();
		}
		// ExEnd: AddPageNumberFieldDocumentExample

	}

}
