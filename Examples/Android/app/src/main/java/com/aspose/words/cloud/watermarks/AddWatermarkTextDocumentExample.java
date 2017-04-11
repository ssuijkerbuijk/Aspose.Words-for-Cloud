package com.aspose.words.cloud.watermarks;

import java.io.File;
import java.io.InputStream;





import java.io.File; import com.aspose.storage.api.StorageApi; import android.content.Context;
import com.aspose.words.api.WordsApi;
import com.aspose.words.cloud.R;
import com.aspose.words.cloud.Utils;
import com.aspose.words.cloud.config.Configuration;
import com.aspose.words.model.DocumentResponse;
import com.aspose.words.model.WatermarkText;

public class AddWatermarkTextDocumentExample {

	public static void execute(Context context) throws Exception {
		// ExStart: AddWatermarkTextDocumentExample

		try {
			// Instantiate Aspose Storage API SDK
			StorageApi storageApi = new StorageApi(Configuration.apiKey, Configuration.appSID, true);

			// Instantiate Aspose Words API SDK
			WordsApi wordsApi = new WordsApi(Configuration.apiKey, Configuration.appSID, true);

			// set input file name
			String fileName = "SampleWordDocument.docx";
			String destFileName = "updated-" + fileName;
			Double rotationAngle = 0.0;
			String storage = "";
			String folder = null;
			String text = "New";
			WatermarkText body = new WatermarkText();
			body.setText("aspose.com");

			File input = Utils.stream2file("SampleWordDocument","docx", context.getResources().openRawResource(R.raw.docsample));

			// upload input file to 3rd party cloud storage
			storageApi.PutCreate(fileName, "", storage,
					input);

			// invoke Aspose.Words Cloud SDK API to add watermark text in a word
			// document
			DocumentResponse apiResponse = wordsApi.PostInsertWatermarkText(fileName, text, rotationAngle, destFileName,
					storage, folder, body);

			if (apiResponse != null && apiResponse.getStatus().equals("OK")) {

				System.out.println("Watermark text has been added successfully");
			}

		} catch (Exception e) {
			e.printStackTrace();
		}
		// ExEnd: AddWatermarkTextDocumentExample

	}

}
