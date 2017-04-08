package com.aspose.words.cloud.mailmerge;

import java.io.File;
import java.io.InputStream;





import java.io.File; import com.aspose.storage.api.StorageApi; import android.content.Context;
import com.aspose.words.api.WordsApi;
import com.aspose.words.cloud.R;
import com.aspose.words.cloud.Utils;
import com.aspose.words.cloud.config.Configuration;
import com.aspose.words.model.DocumentResponse;

public class ExecuteMailMergeWithRegionsExample {

	public static void execute(Context context) throws Exception {
		// ExStart: ExecuteMailMergeWithRegionsExample

		try {
			// Instantiate Aspose Storage API SDK
			StorageApi storageApi = new StorageApi(Configuration.apiKey, Configuration.appSID, true);

			// Instantiate Aspose Words API SDK
			WordsApi wordsApi = new WordsApi(Configuration.apiKey, Configuration.appSID, true);

			// set input file name
			String fileName = "SampleInvoiceTemplate.doc";
			File input = Utils.stream2file("SampleInvoiceTemplate","doc", context.getResources().openRawResource(R.raw.SampleInvoiceTemplate));


			String cleanup = null;
			String destFileName = "updated-" + fileName;
			String mailMergeDataFile = null;
			String storage = null;
			String folder = null;
			Boolean useWholeParagraphAsRegion = false;
			Boolean withRegions = true;
			File file;

			// upload input file to aspose cloud storage
			storageApi.PutCreate(fileName, "", "", input);

			// set input file data name
			String fileDataName = "SampleInvoiceTemplateData.txt";

			File fileData = Utils.stream2file("SampleInvoiceTemplateData","txt", context.getResources().openRawResource(R.raw.SampleInvoiceTemplateData));

			// invoke Aspose.Words Cloud SDK API to execute mail merge and
			// populate a word document from XML data
			DocumentResponse apiResponse = wordsApi.PostDocumentExecuteMailMerge(fileName, withRegions,
					mailMergeDataFile, cleanup, destFileName, storage, folder, useWholeParagraphAsRegion, input);

			if (apiResponse != null && apiResponse.getStatus().equals("OK")) {

				System.out.println("mail merge template has been executed successfully");

			}

		} catch (Exception e) {
			e.printStackTrace();
		}
		// ExEnd: ExecuteMailMergeWithRegionsExample
	}

}
