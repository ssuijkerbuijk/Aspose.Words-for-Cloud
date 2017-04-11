package com.aspose.words.cloud.drawing;

import java.io.File;


import com.aspose.words.cloud.R;
import com.aspose.words.cloud.Utils;


import java.io.File; import com.aspose.storage.api.StorageApi; import android.content.Context;
import com.aspose.words.api.WordsApi;
import com.aspose.words.cloud.R;
import com.aspose.words.cloud.config.Configuration;
import com.aspose.words.model.ResponseMessage;

public class GetOLEImageDataFromWordDocumentExample {

	public static void execute(Context context) throws Exception {
		//ExStart: GetOLEImageDataFromWordDocumentExample
		try {
			// Instantiate Aspose Storage API SDK
			StorageApi storageApi = new StorageApi(Configuration.apiKey, Configuration.appSID, true);

			// Instantiate Aspose Words API SDK
			WordsApi wordsApi = new WordsApi(Configuration.apiKey, Configuration.appSID, true);

			File input = Utils.stream2file("SampleWordDocument","docx", context.getResources().openRawResource(R.raw.docsample));

			// set input file name
			String fileName = "SampleOlePdfData.docx";
			Integer objectIndex = 0;

			String storage = null;
			String folder = null;

			// upload input file to aspose cloud storage
			storageApi.PutCreate(fileName, "", "",input);

			// invoke Aspose.Words Cloud SDK API to get ole
			// drawing object by index in a word document
			ResponseMessage apiResponse = wordsApi.GetDocumentDrawingObjectOleData(fileName, objectIndex, storage,
					folder);

			if (apiResponse != null && apiResponse.getStatus().equals("OK") && apiResponse.getInputStream() != null) {
				String destFileName = "OLEDrawingObject_" + objectIndex;
				File desination=Utils.createTempFile(destFileName, ".png");
				Utils.copyInputStreamToFile(apiResponse.getInputStream(),desination);
			}

		} catch (Exception e) {
			e.printStackTrace();
		}
		//ExEnd: GetOLEImageDataFromWordDocumentExample

	}

}
