package com.aspose.words.cloud.fields;

import java.nio.file.Path;

import com.aspose.storage.api.StorageApi;
import com.aspose.words.api.WordsApi;
import com.aspose.words.cloud.config.Configuration;
import com.aspose.words.cloud.config.Utils;
import com.aspose.words.cloud.convert.AppendDocumentExample;
import com.aspose.words.model.FieldNamesResponse;

public class GetMergeFieldsFromDocumentExample {
	public static void main(String[] argv) {
		// ExStart: GetMergeFieldsFromDocumentExample
		try {
			// Instantiate Aspose Storage API SDK
			StorageApi storageApi = new StorageApi(Configuration.apiKey, Configuration.appSID, true);

			// Instantiate Aspose Words API SDK
			WordsApi wordsApi = new WordsApi(Configuration.apiKey, Configuration.appSID, true);

			// set input file name
			String fileName = "SampleMailMergeTemplate.docx";

			String storage = null;
			String folder = null;
			Path p1=Utils.getPath(AppendDocumentExample.class, fileName);
			// upload input file to aspose cloud storage
			storageApi.PutCreate(fileName, "", "",p1.toFile());

			// invoke Aspose.Words Cloud SDK API to get merge field names from a
			// word document
			FieldNamesResponse apiResponse = wordsApi.GetDocumentFieldNames(fileName, false, storage, folder);

			if (apiResponse != null && apiResponse.getStatus().equals("OK")) {

				// Get all merge field names from document
				for (String fieldName : apiResponse.getFieldNames().getNames()) {
					System.out.println(fieldName);

				}
			}

		} catch (Exception e) {
			e.printStackTrace();
		}
		// ExEnd: GetMergeFieldsFromDocumentExample
	}
}
