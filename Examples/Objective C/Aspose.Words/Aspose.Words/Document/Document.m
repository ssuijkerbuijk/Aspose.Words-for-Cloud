//
//  Document.m
//  Aspose.Words
//
//  Created by Muhammad Sohail Ismail on 16/03/2017.
//  Copyright © 2017 Aspose. All rights reserved.
//

#import "Document.h"
#import "Utils.h"
#import "ASPWordsApi.h"

@implementation Document

- (id)init {
    self = [super init];
    
    self.wordsApi = [[ASPWordsApi alloc] init];
    
    return self;
}

- (void)testAcceptAllRevisions {
//ExStart:TestAcceptAllRevisions
    
    NSString *fileName = @"SampleWordDocument.docx";
    [Utils uploadFile:fileName];
    
    [self.wordsApi acceptAllRevisionsWithCompletionBlock:fileName
                                                filename:nil
                                                 storage:nil
                                                  folder:nil
                                       completionHandler:^(ASPRevisionsModificationResponse *output, NSError *error) {
                                           NSLog(@"%@", output);
                                       }];
//ExEnd:TestAcceptAllRevisions
}

- (void)deleteDocumentMacros {
//ExStart:DeleteDocumentMacros
    
    NSString *fileName = @"Test.docx";
    [Utils uploadFile:fileName];
    
    [self.wordsApi deleteDocumentMacrosWithCompletionBlock:fileName
                                                   storage:nil
                                                    folder:nil
                                         completionHandler:^(ASPBaseResponse *output, NSError *error) {
                                             NSLog(@"%@", output);
                                         }];
//ExEnd:DeleteDocumentMacros
}

- (void)getDocument {
//ExStart:GetDocument
    
    NSString *fileName = @"SampleWordDocument.docx";
    [Utils uploadFile:fileName];
    
    [self.wordsApi getDocumentWithCompletionBlock:fileName
                                          storage:nil
                                           folder:nil
                                completionHandler:^(ASPDocumentResponse *output, NSError *error) {
                                    NSLog(@"%@", output);
                                }];
//ExEnd:GetDocument
}

- (void)getDocumentStatistics {
//ExStart:GetDocumentStatistics
    
    NSString *fileName = @"SampleWordDocument.docx";
    [Utils uploadFile:fileName];
    
    [self.wordsApi getDocumentStatisticsWithCompletionBlock:fileName
                                            includeComments:[NSNumber numberWithBool:YES]
                                           includeFootnotes:[NSNumber numberWithBool:YES]
                                        includeTextInShapes:[NSNumber numberWithBool:YES]
                                                    storage:nil
                                                     folder:nil
                                          completionHandler:^(ASPStatDataResponse *output, NSError *error) {
                                              NSLog(@"%@", output);
                                          }];
//ExEnd:GetDocumentStatistics
}

- (void)getDocumentWithFormat {
//ExStart:GetDocumentWithFormat
    
    NSString *fileName = @"SampleWordDocument.docx";
    [Utils uploadFile:fileName];
    
    [self.wordsApi getDocumentWithFormatWithCompletionBlock:fileName
                                                     format:@"pdf"
                                                    storage:nil
                                                     folder:nil
                                                    outPath:nil
                                          completionHandler:^(NSURL *output, NSError *error) {
                                              NSLog(@"%@", output);
                                          }];
//ExEnd:GetDocumentWithFormat
}

- (void)postAppendDocument {
//ExStart:PostAppendDocument
    
    NSString *fileName = @"SampleWordDocument.docx";
    [Utils uploadFile:fileName];
    
    ASPDocumentEntry *document1 = [[ASPDocumentEntry alloc] init];
    document1.href = @"SampleAppendDoc.docx";
    document1.importFormatMode = @"KeepSourceFormatting";
    
    ASPDocumentEntry *document2 = [[ASPDocumentEntry alloc] init];
    document2.href = @"SampleAppendDoc2.docx";
    document2.importFormatMode = @"KeepSourceFormatting";
    
    ASPDocumentEntryList *documentList = [[ASPDocumentEntryList alloc] init];
    documentList.documentEntries = (NSArray<ASPDocumentEntry>*) @[document1, document2];
    
    
    [self.wordsApi postAppendDocumentWithCompletionBlock:fileName
                                            documentList:documentList
                                                filename:nil
                                                 storage:nil
                                                  folder:nil
                                       completionHandler:^(ASPDocumentResponse *output, NSError *error) {
                                           NSLog(@"%@", output);
                                       }];
//ExEnd:PostAppendDocument
}

- (void)postDocumentSaveAs {
    
    ASPSaveOptionsData *saveOptions = [[ASPSaveOptionsData alloc] init];
    saveOptions.fileName = @"SampleWordDocument.pdf";
    saveOptions.saveFormat = @"pdf";
    
    [self.wordsApi postDocumentSaveAsWithCompletionBlock:@"SampleWordDocument.docx"
                                         saveOptionsData:saveOptions
                                                 storage:nil
                                                  folder:nil
                                       completionHandler:^(ASPSaveResponse *output, NSError *error) {
                                           NSLog(@"%@", output);
                                       }];
    
    
    saveOptions = [[ASPSaveOptionsData alloc] init];
    saveOptions.fileName = @"AppendWordDocumentsExample-TestFile-Destination.pdf";
    saveOptions.saveFormat = @"pdf";
    
    [self.wordsApi postDocumentSaveAsWithCompletionBlock:@"AppendWordDocumentsExample-TestFile-Destination.doc"
                                         saveOptionsData:saveOptions
                                                 storage:nil
                                                  folder:nil
                                       completionHandler:^(ASPSaveResponse *output, NSError *error) {
                                           NSLog(@"%@", output);
                                       }];
    
    saveOptions = [[ASPSaveOptionsData alloc] init];
    saveOptions.fileName = @"AppendWordDocumentsExample-TestFile-Source.pdf";
    saveOptions.saveFormat = @"pdf";
    
    [self.wordsApi postDocumentSaveAsWithCompletionBlock:@"AppendWordDocumentsExample-TestFile-Source.doc"
                                         saveOptionsData:saveOptions
                                                 storage:nil
                                                  folder:nil
                                       completionHandler:^(ASPSaveResponse *output, NSError *error) {
                                           NSLog(@"%@", output);
                                       }];
    
    saveOptions = [[ASPSaveOptionsData alloc] init];
    saveOptions.fileName = @"DHA Application Form.pdf";
    saveOptions.saveFormat = @"pdf";
    
    [self.wordsApi postDocumentSaveAsWithCompletionBlock:@"DHA Application Form.docx"
                                         saveOptionsData:saveOptions
                                                 storage:nil
                                                  folder:nil
                                       completionHandler:^(ASPSaveResponse *output, NSError *error) {
                                           NSLog(@"%@", output);
                                       }];
    
    saveOptions = [[ASPSaveOptionsData alloc] init];
    saveOptions.fileName = @"FormFilled.pdf";
    saveOptions.saveFormat = @"pdf";
    
    [self.wordsApi postDocumentSaveAsWithCompletionBlock:@"FormFilled.docx"
                                         saveOptionsData:saveOptions
                                                 storage:nil
                                                  folder:nil
                                       completionHandler:^(ASPSaveResponse *output, NSError *error) {
                                           NSLog(@"%@", output);
                                       }];
    
    saveOptions = [[ASPSaveOptionsData alloc] init];
    saveOptions.fileName = @"SampleBlankWordDocument.pdf";
    saveOptions.saveFormat = @"pdf";
    
    [self.wordsApi postDocumentSaveAsWithCompletionBlock:@"SampleBlankWordDocument.docx"
                                         saveOptionsData:saveOptions
                                                 storage:nil
                                                  folder:nil
                                       completionHandler:^(ASPSaveResponse *output, NSError *error) {
                                           NSLog(@"%@", output);
                                       }];
    
    saveOptions = [[ASPSaveOptionsData alloc] init];
    saveOptions.fileName = @"doc-sample-hyperlink.pdf";
    saveOptions.saveFormat = @"pdf";
    
    [self.wordsApi postDocumentSaveAsWithCompletionBlock:@"doc-sample-hyperlink.doc"
                                         saveOptionsData:saveOptions
                                                 storage:nil
                                                  folder:nil
                                       completionHandler:^(ASPSaveResponse *output, NSError *error) {
                                           NSLog(@"%@", output);
                                       }];
    
    saveOptions = [[ASPSaveOptionsData alloc] init];
    saveOptions.fileName = @"doc-sample-protect.pdf";
    saveOptions.saveFormat = @"pdf";
    
    [self.wordsApi postDocumentSaveAsWithCompletionBlock:@"doc-sample-protect.doc"
                                         saveOptionsData:saveOptions
                                                 storage:nil
                                                  folder:nil
                                       completionHandler:^(ASPSaveResponse *output, NSError *error) {
                                           NSLog(@"%@", output);
                                       }];
    
    saveOptions = [[ASPSaveOptionsData alloc] init];
    saveOptions.fileName = @"doc-sample-unprotect.pdf";
    saveOptions.saveFormat = @"pdf";
    
    [self.wordsApi postDocumentSaveAsWithCompletionBlock:@"doc-sample-unprotect.doc"
                                         saveOptionsData:saveOptions
                                                 storage:nil
                                                  folder:nil
                                       completionHandler:^(ASPSaveResponse *output, NSError *error) {
                                           NSLog(@"%@", output);
                                       }];
    
    saveOptions = [[ASPSaveOptionsData alloc] init];
    saveOptions.fileName = @"doc-sample-watermark.pdf";
    saveOptions.saveFormat = @"pdf";
    
    [self.wordsApi postDocumentSaveAsWithCompletionBlock:@"doc-sample-watermark.doc"
                                         saveOptionsData:saveOptions
                                                 storage:nil
                                                  folder:nil
                                       completionHandler:^(ASPSaveResponse *output, NSError *error) {
                                           NSLog(@"%@", output);
                                       }];
}

- (void)postLoadWebDocument {
//ExStart:PostLoadWebDocument
    
    ASPLoadWebDocumentData *loadWebDocumentData = [[ASPLoadWebDocumentData alloc] init];
    loadWebDocumentData.loadingDocumentUrl = @"http://google.com";
    
    ASPSaveOptionsData *saveOptions = [[ASPSaveOptionsData alloc] init];
    saveOptions.saveFormat = @"doc";
    saveOptions.fileName = @"google.doc";
    
    loadWebDocumentData.saveOptions = saveOptions;
    
    [self.wordsApi postLoadWebDocumentWithCompletionBlock:loadWebDocumentData completionHandler:^(ASPSaveResponse *output, NSError *error) {
        NSLog(@"%@", output);
    }];
//ExEnd:PostLoadWebDocument
}

- (void)postRunTask {
//ExStart:PostRunTask
    
    NSURL *pathToFile = [[NSBundle mainBundle] URLForResource:@"SampleWordDocument" withExtension:@"docx"];
    
    [self.wordsApi postRunTaskWithCompletionBlock:pathToFile completionHandler:^(ASPResponseMessage *output, NSError *error) {
        NSLog(@"%@", output);
    }];
//ExEnd:PostRunTask
}

- (void)putConvertDocument {
//ExStart:PutConvertDocument
    NSURL *pathToFile = [[NSBundle mainBundle] URLForResource:@"SampleWordDocument" withExtension:@"docx"];
    
    [self.wordsApi putConvertDocumentWithCompletionBlock:pathToFile
                                                  format:@"pdf"
                                                 outPath:nil
                                  replaceResourcesHostTo:nil
                                       completionHandler:^(NSURL *output, NSError *error) {
                                           NSLog(@"%@", output);
                                       }];
//ExEnd:PutConvertDocument
}

- (void)putDocumentSaveAsTiff {
//ExStart:PutDocumentSaveAsTiff
    
    NSString *fileName = @"SampleWordDocument.docx";
    [Utils uploadFile:fileName];
    
    ASPTiffSaveOptionsData *tiffSaveOptions = [[ASPTiffSaveOptionsData alloc] init];
    tiffSaveOptions.fileName = @"SampleWordDocument.tiff";
    tiffSaveOptions.saveFormat = @"tiff";
    
    [self.wordsApi putDocumentSaveAsTiffWithCompletionBlock:fileName
                                                saveOptions:tiffSaveOptions
                                                 resultFile:nil
                                            useAntiAliasing:nil
                                    useHighQualityRendering:nil
                                            imageBrightness:nil
                                             imageColorMode:nil
                                              imageContrast:nil
                                              numeralFormat:nil
                                                  pageCount:nil
                                                  pageIndex:nil
                                                 paperColor:nil
                                                pixelFormat:nil
                                                 resolution:nil
                                                      scale:nil
                                            tiffCompression:nil
                                           dmlRenderingMode:nil
                                    dmlEffectsRenderingMode:nil
                                     tiffBinarizationMethod:nil
                                                    storage:nil
                                                     folder:nil
                                                  zipOutput:nil
                                          completionHandler:^(ASPSaveResponse *output, NSError *error) {
                                              NSLog(@"%@", output);
                                          }];
//ExEnd:PutDocumentSaveAsTiff
}

- (void)testRejectAllRevisions {
//ExStart:TestRejectAllRevisions
    
    NSString *fileName = @"SampleWordDocument.docx";
    [Utils uploadFile:fileName];
    
    [self.wordsApi rejectAllRevisionsWithCompletionBlock:fileName
                                                filename:nil
                                                 storage:nil
                                                  folder:nil
                                       completionHandler:^(ASPRevisionsModificationResponse *output, NSError *error) {
                                           NSLog(@"%@", output);
                                       }];
//ExEnd:TestRejectAllRevisions
}

@end
