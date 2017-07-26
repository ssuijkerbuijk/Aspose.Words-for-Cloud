package com.aspose.words.cloud.convert;

import java.nio.file.Path;

import com.aspose.storage.api.StorageApi;
import com.aspose.words.api.WordsApi;
import com.aspose.words.cloud.config.Configuration;
import com.aspose.words.cloud.config.Utils;
import com.aspose.words.model.ResponseMessage;

public class RenderPagesExample {

	public static void main(String[] args) {
		// ExStart: 1
		try {
			// Instantiate Aspose Storage API SDK
			StorageApi storageApi = new StorageApi(Configuration.apiKey, Configuration.appSID, false);

			// Instantiate Aspose Words API SDK
			WordsApi wordsApi = new WordsApi(Configuration.apiKey, Configuration.appSID, false);

			// set input file name
			String fileName = "SampleWordDocument.docx";

			// set the desire output format
			String format = "bmp";
			String storage = "";
			String folder = "";
			Integer pageNumber = 1;

			Path p1 = Utils.getPath(ConvertDocumentToFormatExample.class, fileName);

			// upload file to aspose cloud storage
			storageApi.PutCreate(fileName, "", "", p1.toFile());

			// invoke Aspose.Words Cloud SDK API to convert words document to
			// required format
			ResponseMessage apiResponse = wordsApi.GetRenderPage(fileName, pageNumber, format, storage, folder);

			if (apiResponse != null) {
				// save api response to file
				System.out.println("Page rendered successfully");
			}

		} catch (Exception e) {
			e.printStackTrace();
		}
		// ExEnd: 1

	}

}
