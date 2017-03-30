package com.aspose.words.cloud.paragraphs;

import java.io.File;

import com.aspose.storage.api.StorageApi;
import com.aspose.words.api.WordsApi;
import com.aspose.words.cloud.config.Configuration;
import com.aspose.words.model.Run;
import com.aspose.words.model.RunResponse;

public class ReadingSpecificRunParagraphExample {

	public static void main(String[] args) {
		// ExStart: ReadingSpecificRunParagraphExample

		try {
			// Instantiate Aspose Storage API SDK
			StorageApi storageApi = new StorageApi(Configuration.apiKey, Configuration.appSID, true);

			// Instantiate Aspose Words API SDK
			WordsApi wordsApi = new WordsApi(Configuration.apiKey, Configuration.appSID, true);

			// set input file name
			String fileName = "SampleWordDocument.docx";
			Integer index = 1;
			Integer runIndex = 0;
			String storage = null;
			String folder = null;

			// upload input file to aspose cloud storage
			storageApi.PutCreate(fileName, "", "",
					new File(ReadingSpecificRunParagraphExample.class.getResource("/" + fileName).toURI()));

			// invoke Aspose.Words Cloud SDK API to get a specific run of a
			// paragraph from a word document
			RunResponse apiResponse = wordsApi.GetDocumentParagraphRun(fileName, index, runIndex, storage, folder);

			if (apiResponse != null && apiResponse.getStatus().equals("OK")) {

				Run docParagraphRun = apiResponse.getRun();
				// display document paragraph run info
				if (docParagraphRun != null) {
					System.out.println("NoteId : " + docParagraphRun.getNodeId());
					System.out.println("Link : " + docParagraphRun.getText());
				}
			}

		} catch (Exception e) {
			e.printStackTrace();
		}
		// ExEnd: ReadingSpecificRunParagraphExample

	}

}
