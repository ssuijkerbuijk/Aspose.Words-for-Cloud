package com.aspose.words.cloud.mailmerge;

import java.io.File;
import java.io.InputStream;





import java.io.File; import com.aspose.storage.api.StorageApi; import android.content.Context;
import com.aspose.words.api.WordsApi;
import com.aspose.words.cloud.R;
import com.aspose.words.cloud.Utils;
import com.aspose.words.cloud.config.Configuration;
import com.aspose.words.model.DocumentResponse;

public class ExecuteMailMergeTemplateExample {

	public static void execute(Context context) throws Exception {
		// ExStart: ExecuteMailMergeTemplateExample
		try {
			// Instantiate Aspose Storage API SDK
			StorageApi storageApi = new StorageApi(Configuration.apiKey, Configuration.appSID, true);

			// Instantiate Aspose Words API SDK
			WordsApi wordsApi = new WordsApi(Configuration.apiKey, Configuration.appSID, true);

			// set input file name
			String fileName = "SampleExecuteTemplate.docx";
			File input = Utils.stream2file("SampleExecuteTemplate","docx", context.getResources().openRawResource(R.raw.sampleexecutetemplate));



			String cleanup = null;
			String destFileName = "updated-" + fileName;
			String storage = null;
			String folder = null;
			Boolean useWholeParagraphAsRegion = null;
			Boolean withRegions = null;
			File file;

			// upload input file to aspose cloud storage
			storageApi.PutCreate(fileName, "", "",
					input);

			// set input file data name
			String fileDataName = "SampleExecuteTemplateData.txt";

			File fileData = Utils.stream2file("SampleExecuteTemplateData","txt", context.getResources().openRawResource(R.raw.sampleexecutetemplate));

			// invoke Aspose.Words Cloud SDK API to execute mail merge template
			// and populate a word document from XML data
			DocumentResponse apiResponse = wordsApi.PostExecuteTemplate(fileName, cleanup, destFileName, storage,
					folder, useWholeParagraphAsRegion, withRegions, fileData);

			if (apiResponse != null && apiResponse.getStatus().equals("OK")) {

				System.out.println("mail merge template has been executed successfully");

			}

		} catch (Exception e) {
			e.printStackTrace();
		}
		// ExEnd: ExecuteMailMergeTemplateExample

	}

}
