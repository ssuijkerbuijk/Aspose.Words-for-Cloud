package com.aspose.words.cloud.headersfooters;

import java.io.File;
import java.io.InputStream;





import java.io.File; import com.aspose.storage.api.StorageApi; import android.content.Context;
import com.aspose.words.api.WordsApi;
import com.aspose.words.cloud.R;
import com.aspose.words.cloud.Utils;
import com.aspose.words.cloud.config.Configuration;
import com.aspose.words.model.SaaSposeResponse;

public class RemovingHeaderFootersDocumentExample {

	public static void execute(Context context) throws Exception {
		// ExStart: RemovingHeaderFootersDocumentExample
		try {
			// Instantiate Aspose Storage API SDK
			StorageApi storageApi = new StorageApi(Configuration.apiKey, Configuration.appSID, true);

			// Instantiate Aspose Words API SDK
			WordsApi wordsApi = new WordsApi(Configuration.apiKey, Configuration.appSID, true);

			// set input file name
			String fileName = "SampleHeaderFooterWordDocument.docx";
			File input = Utils.stream2file("SampleWordDocument","docx", context.getResources().openRawResource(R.raw.docsample));


			String destFileName = "updated-" + fileName;
			String headersFootersTypes = null;
			String storage = null;
			String folder = null;

			// upload input file to aspose cloud storage
			storageApi.PutCreate(fileName, "", "", input);

			// invoke Aspose.Words Cloud SDK API to remove all headers and
			// footers from a word document
			SaaSposeResponse apiResponse = wordsApi.DeleteHeadersFooters(fileName, headersFootersTypes, destFileName,
					storage, folder);

			if (apiResponse != null && apiResponse.getStatus().equals("OK")) {

				System.out.println("All headers and footers have been deleted successfully");
			}

		} catch (Exception e) {
			e.printStackTrace();
		}
		// ExEnd: RemovingHeaderFootersDocumentExample

	}

}
