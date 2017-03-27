package com.aspose.words.cloud.paragraphs;

import java.io.File;
import java.io.InputStream;
import java.nio.file.Files;
import java.nio.file.Path;
import java.nio.file.Paths;
import java.nio.file.StandardCopyOption;

import com.aspose.storage.api.StorageApi;
import com.aspose.words.api.WordsApi;
import com.aspose.words.cloud.config.Configuration;
import com.aspose.words.model.Font;
import com.aspose.words.model.FontResponse;

public class UpdatingFontForRunParagraphExample {

	public static void main(String[] args) {
		// ExStart: UpdatingFontForRunParagraphExample

		try {
			// Instantiate Aspose Storage API SDK
			StorageApi storageApi = new StorageApi(Configuration.apiKey, Configuration.appSID, true);

			// Instantiate Aspose Words API SDK
			WordsApi wordsApi = new WordsApi(Configuration.apiKey, Configuration.appSID, true);

			// set input file name
			String fileName = "SampleWordDocument.docx";
			String destFileName = "updated-" + fileName;
			Integer index = 0;
			Integer runIndex = 0;
			String storage = null;
			String folder = null;

			Font body = new Font();
			body.setBold(true);
			body.setSize(31.0);
			body.setName("Calibri");

			// upload input file to aspose cloud storage
			storageApi.PutCreate(fileName, "", "",
					new File(UpdatingFontForRunParagraphExample.class.getResource("/" + fileName).toURI()));

			// invoke Aspose.Words Cloud SDK API to update font of a specific
			// run of a paragraph present in a word document
			FontResponse apiResponse = wordsApi.PostDocumentParagraphRunFont(fileName, index, runIndex, storage, folder,
					destFileName, body);

			if (apiResponse != null && apiResponse.getStatus().equals("OK")) {

				System.out.println("paragraph run font has been updated successfully");

				// download updated file from cloud storage
				com.aspose.storage.model.ResponseMessage storageRes = storageApi.GetDownload(destFileName, null, null);

				InputStream responseStream = storageRes.getInputStream();

				final Path destination = Paths.get(destFileName);

				Files.copy(responseStream, destination, StandardCopyOption.REPLACE_EXISTING);
			}

		} catch (Exception e) {
			e.printStackTrace();
		}
		// ExEnd: UpdatingFontForRunParagraphExample

	}

}
