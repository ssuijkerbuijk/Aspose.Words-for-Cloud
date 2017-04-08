package com.aspose.words.cloud.sections;

import java.nio.file.Path;

import com.aspose.storage.api.StorageApi;
import com.aspose.words.api.WordsApi;
import com.aspose.words.cloud.config.Configuration;
import com.aspose.words.cloud.config.Utils;
import com.aspose.words.cloud.properties.DeletingDocumentPropertyExample;
import com.aspose.words.model.PageSetup;
import com.aspose.words.model.SectionPageSetupResponse;

public class GetSectionsPageSetupExample {

	public static void main(String[] args) {
		//ExStart: GetSectionsPageSetupExample
		String fileName = "SampleBlankWordDocument.docx";
		int sectionIndex = 0;
		String storage = null;
		String folder = null;

		try {
			// Instantiate Aspose Storage API SDK
			StorageApi storageApi = new StorageApi(Configuration.apiKey, Configuration.appSID, true);
			// Instantiate Aspose Words API SDK
			WordsApi wordsApi = new WordsApi(Configuration.apiKey, Configuration.appSID, true);
			
            Path p1=Utils.getPath(DeletingDocumentPropertyExample.class, fileName);


			// Upload the file
			storageApi.PutCreate(fileName, "", storage,p1.toFile());
			// Invoke Aspose.Words Cloud SDK API to extract page setup
			// informations
			
			
			
			SectionPageSetupResponse apiResponse = wordsApi.GetSectionPageSetup(fileName, sectionIndex, storage,
					folder);

			if (apiResponse != null && apiResponse.getStatus().equals("OK")) {
				PageSetup secPageSetup = apiResponse.getPageSetup();
				System.out.println(
						"getPaperSize :" + secPageSetup.getPaperSize() + "  Orientation:  " + secPageSetup.getOrientation());
			}
		} catch (Exception ex) {
			ex.printStackTrace();
		}
		//ExEnd: GetSectionsPageSetupExample

	}

}
