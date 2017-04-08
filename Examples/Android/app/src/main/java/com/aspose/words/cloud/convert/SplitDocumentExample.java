package com.aspose.words.cloud.convert;

import java.io.File;
import java.io.InputStream;
import com.aspose.words.cloud.R;
import com.aspose.words.cloud.Utils;

import java.io.File; import com.aspose.storage.api.StorageApi; import android.content.Context;
import com.aspose.words.api.WordsApi;
import com.aspose.words.cloud.config.Configuration;
import com.aspose.words.model.Link;
import com.aspose.words.model.SplitDocumentResponse;

public class SplitDocumentExample {

	public static void execute(Context context) throws Exception {
		// ExStart: SplitDocumentExample
		try {
			// Instantiate Aspose Storage API SDK
			StorageApi storageApi = new StorageApi(Configuration.apiKey, Configuration.appSID, true);

			// Instantiate Aspose Words API SDK
			WordsApi wordsApi = new WordsApi(Configuration.apiKey, Configuration.appSID, true);

			// set input file name
			String fileName = "SampleWordDocument.docx";
			String format = "pdf";
			Integer from = 2;
			Integer to = 3;
			Boolean zipOutput = false;
			String storage = null;
			String folder = null;

			File input = Utils.stream2file("SampleWordDocument","docx", context.getResources().openRawResource(R.raw.SampleWordDocument));

			// upload input file to aspose cloud storage
			storageApi.PutCreate(fileName, "", "",
					input);

			// invoke Aspose.Words Cloud SDK API to split word document
			SplitDocumentResponse apiResponse = wordsApi.PostSplitDocument(fileName, format, from, to, zipOutput,
					storage, folder);

			if (apiResponse != null && apiResponse.getStatus().equals("OK")) {
				System.out.println("Document has been splitted to pfds successfully");

				// download splitted pdfs from storage server
				for (Link pageLink : apiResponse.getSplitResult().getPages()) {
					String outputFileName = pageLink.getHref();
					com.aspose.storage.model.ResponseMessage storageRes = storageApi.GetDownload(outputFileName, null,
							null);
					InputStream responseStream = storageRes.getInputStream();

					File outputFile=Utils.createTempFile(outputFileName,"docx");

					Utils.copyInputStreamToFile(storageRes.getInputStream(),outputFile);

				}
			}

		} catch (Exception e) {
			e.printStackTrace();
		}
		// ExEnd: SplitDocumentExample

	}
}
