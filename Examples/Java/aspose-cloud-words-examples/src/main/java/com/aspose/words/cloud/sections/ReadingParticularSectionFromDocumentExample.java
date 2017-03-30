package com.aspose.words.cloud.sections;

import java.io.File;

import com.aspose.storage.api.StorageApi;
import com.aspose.words.api.WordsApi;
import com.aspose.words.cloud.config.Configuration;
import com.aspose.words.model.SectionResponse;

public class ReadingParticularSectionFromDocumentExample {

	public static void main(String[] args) {
		// ExStart: ReadingParticularSectionFromDocumentExample

		try {
			// Instantiate Aspose Storage API SDK
			StorageApi storageApi = new StorageApi(Configuration.apiKey, Configuration.appSID, true);

			// Instantiate Aspose Words API SDK
			WordsApi wordsApi = new WordsApi(Configuration.apiKey, Configuration.appSID, true);

			// set input file name
			String fileName = "SampleWordDocument.docx";

			Integer sectionIndex = 0;
			String storage = null;
			String folder = null;

			// upload input file to aspose cloud storage
			storageApi.PutCreate(fileName, "", "",
					new File(ReadingParticularSectionFromDocumentExample.class.getResource("/" + fileName).toURI()));

			// invoke Aspose.Words Cloud SDK API to get a specific section
			// present from a word document
			SectionResponse apiResponse = wordsApi.GetSection(fileName, sectionIndex, storage, folder);

			if (apiResponse != null && apiResponse.getStatus().equals("OK")) {
				// get section href
				System.out.println(apiResponse.getSection().getLink().getHref());

			}

		} catch (Exception e) {
			e.printStackTrace();
		}
		// ExEnd: ReadingParticularSectionFromDocumentExample

	}

}
