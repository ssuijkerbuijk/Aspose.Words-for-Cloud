package com.aspose.words.cloud.convert;

import java.io.File;
import java.io.InputStream;





import java.io.File; import com.aspose.storage.api.StorageApi; import android.content.Context;
import com.aspose.words.api.WordsApi;
import com.aspose.words.cloud.R;
import com.aspose.words.cloud.Utils;
import com.aspose.words.cloud.config.Configuration;
import com.aspose.words.model.ResponseMessage;

public class ConvertDocumentToFormatExample {

	public static void execute(Context context) throws  Exception {
		// ExStart: ConvertDocumentToFormatExample
		try {
			// Instantiate Aspose Storage API SDK
			StorageApi storageApi = new StorageApi(Configuration.apiKey, Configuration.appSID, true);

			// Instantiate Aspose Words API SDK
			WordsApi wordsApi = new WordsApi(Configuration.apiKey, Configuration.appSID, true);

			// set input file name
			String fileName = "test_doc.docx";

			// set the desire output format
			String format = "pdf";
			String storage = "";
			String folder = "";
			String outPath = "";

			File input = Utils.stream2file("SampleWordDocument","docx", context.getResources().openRawResource(R.raw.docsample));

			// upload file to aspose cloud storage
			storageApi.PutCreate(fileName, "", "", input);

			// invoke Aspose.Words Cloud SDK API to convert words document to
			// required format
			ResponseMessage apiResponse = wordsApi.GetDocumentWithFormat(fileName, format, storage, folder, outPath);

			if (apiResponse != null && apiResponse.getInputStream() != null) {
				// save api response to file
				InputStream responseStream = apiResponse.getInputStream();

				Utils.copyInputStreamToFile(responseStream,input);
			}

		} catch (Exception e) {
			e.printStackTrace();
		}
		// ExEnd: ConvertDocumentToFormatExample
	}
}
