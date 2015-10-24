//
//  ASPWordsApiTestCase.m
//  Aspose.Words_Cloud_SDK_for_ObjectiveC
//
//  Created by Muhammad Sohail Ismail on 17/10/2015.
//  Copyright © 2015 Aspose. All rights reserved.
//

#import <XCTest/XCTest.h>
#import "ASPWordsApi.h"
#import "ASPStorageApi.h"

@interface ASPWordsApiTestCase : XCTestCase
@property(nonatomic, strong) ASPWordsApi *wordsApi;
@end

@implementation ASPWordsApiTestCase

- (void)setUp {
    [super setUp];
    // Put setup code here. This method is called before the invocation of each test method in the class.
    self.wordsApi = [[ASPWordsApi alloc] init];
}

- (void)tearDown {
    // Put teardown code here. This method is called after the invocation of each test method in the class.
    [super tearDown];
}

- (void)uploadFile:(NSString *) fileName {
    XCTestExpectation *expectation = [self expectationWithDescription:@""];
    
    ASPStorageApi *storageApi = [[ASPStorageApi alloc] init];
    
    NSURL *pathToFile = [[NSBundle mainBundle] URLForResource:[fileName stringByDeletingPathExtension] withExtension:[fileName pathExtension]];
    [storageApi putCreateWithCompletionBlock:fileName
                                        file:pathToFile
                                   versionId:nil
                                     storage:nil
                           completionHandler:^(ASPBaseResponse *output, NSError *error) {
                               XCTAssertNotNil(output, @"Failed to upload a specific file.");
                               [expectation fulfill];
                           }];
    
    [self waitForExpectationsWithTimeout:180.0 handler:^(NSError *error) {
        if (error) {
            NSLog(@"Timeout Error: %@", error);
        }
    }];
}

- (void)testPutConvertDocument
{
    XCTestExpectation *expectation = [self expectationWithDescription:@""];
    
    NSURL *pathToFile = [[NSBundle mainBundle] URLForResource:@"SampleWordDocument" withExtension:@"docx"];
    
    [self.wordsApi putConvertDocumentWithCompletionBlock:pathToFile
                                                  format:@"pdf"
                                                 outPath:nil
                                  replaceResourcesHostTo:nil
                                       completionHandler:^(NSURL *output, NSError *error) {
        XCTAssertNotNil(output, @"Failed to convert document from request content to specified format.");
        [expectation fulfill];
    }];
    
    [self waitForExpectationsWithTimeout:180.0 handler:^(NSError *error) {
        if (error) {
            NSLog(@"Timeout Error: %@", error);
        }
    }];
}

- (void)testPutExecuteMailMergeOnline
{
    XCTestExpectation *expectation = [self expectationWithDescription:@""];
    
    NSURL *pathToFile = [[NSBundle mainBundle] URLForResource:@"SampleMailMergeTemplate" withExtension:@"docx"];
    NSURL *pathToDataFile = [[NSBundle mainBundle] URLForResource:@"SampleMailMergeTemplateData" withExtension:@"txt"];
    
    /*cleanup parameter contains list of values from below, separated by ",":
    
    None - without any cleanup
    EmptyParagraphs - Specifies whether paragraphs that contained mail merge fields with no data should be removed from the document
    UnusedRegions - Specifies whether unused mail merge regions should be removed from the document
    UnusedFields - Specifies whether unused merge fields should be removed from the document
    ContainingFields - Specifies whether fields that contain merge fields (for example, IFs) should be removed from the document if the nested merge fields are removed
    RemoveTitleRow - Removes title row of the table if this table doesn't contain any rows except title row.
    RemoveTitleRowInInnerTables - Enable "RemoveTitleRow " for nested tables*/

    
    [self.wordsApi putExecuteMailMergeOnlineWithCompletionBlock:[NSNumber numberWithBool:NO]
                                                           file:pathToFile
                                                           data:pathToDataFile
                                                        cleanup:nil
                                              completionHandler:^(NSURL *output, NSError *error) {
                                                  XCTAssertNotNil(output, @"Failed to execute document mail merge online.");
                                                  [expectation fulfill];
                                              }];
    
    [self waitForExpectationsWithTimeout:180.0 handler:^(NSError *error) {
        if (error) {
            NSLog(@"Timeout Error: %@", error);
        }
    }];
}

- (void)testPutExecuteTemplateOnline {
    XCTestExpectation *expectation = [self expectationWithDescription:@""];
    
    NSURL *pathToFile = [[NSBundle mainBundle] URLForResource:@"SampleExecuteTemplate" withExtension:@"doc"];
    NSURL *pathToDataFile = [[NSBundle mainBundle] URLForResource:@"SampleExecuteTemplateData" withExtension:@"txt"];
    
    [self.wordsApi putExecuteTemplateOnlineWithCompletionBlock:pathToFile
                                                          data:pathToDataFile
                                                       cleanup:nil
                                     useWholeParagraphAsRegion:nil
                                                   withRegions:nil
                                             completionHandler:^(NSURL *output, NSError *error) {
                                                 XCTAssertNotNil(output, @"Failed to populate document template with data online");
                                                 [expectation fulfill];
                                             }];
    
    [self waitForExpectationsWithTimeout:180.0 handler:^(NSError *error) {
        if (error) {
            NSLog(@"Timeout Error: %@", error);
        }
    }];
}

- (void)testPostLoadWebDocument {
    
    XCTestExpectation *expectation = [self expectationWithDescription:@""];
    
    ASPLoadWebDocumentData *loadWebDocumentData = [[ASPLoadWebDocumentData alloc] init];
    loadWebDocumentData.loadingDocumentUrl = @"http://google.com";
    
    ASPSaveOptionsData *saveOptions = [[ASPSaveOptionsData alloc] init];
    saveOptions.saveFormat = @"doc";
    saveOptions.fileName = @"google.doc";
    
    loadWebDocumentData.saveOptions = saveOptions;
    
    [self.wordsApi postLoadWebDocumentWithCompletionBlock:loadWebDocumentData completionHandler:^(ASPSaveResponse *output, NSError *error) {
        XCTAssertNotNil(output, @"Failed to load new document from web into the file with any supported format of data");
        [expectation fulfill];
    }];
 
    [self waitForExpectationsWithTimeout:180.0 handler:^(NSError *error) {
        if (error) {
            NSLog(@"Timeout Error: %@", error);
        }
    }];
}

- (void)testPutDocumentFieldNames {
    
    XCTestExpectation *expectation = [self expectationWithDescription:@""];
    
    [self.wordsApi putDocumentFieldNamesWithCompletionBlock:[NSNumber numberWithBool:NO] completionHandler:^(ASPFieldNamesResponse *output, NSError *error) {
        XCTAssertNotNil(output, @"Failed to read document field names");
        [expectation fulfill];
    }];
 
    [self waitForExpectationsWithTimeout:180.0 handler:^(NSError *error) {
        if (error) {
            NSLog(@"Timeout Error: %@", error);
        }
    }];
}

- (void)testPostRunTask {
    XCTestExpectation *expectation = [self expectationWithDescription:@""];
    
    NSURL *pathToFile = [[NSBundle mainBundle] URLForResource:@"SampleWordDocument" withExtension:@"docx"];
    
    [self.wordsApi postRunTaskWithCompletionBlock:pathToFile completionHandler:^(ASPResponseMessage *output, NSError *error) {
        XCTAssertNotNil(output, @"Failed to run tasks");
        [expectation fulfill];
    }];
    
    [self waitForExpectationsWithTimeout:180.0 handler:^(NSError *error) {
        if (error) {
            NSLog(@"Timeout Error: %@", error);
        }
    }];
}

- (void)testGetDocument {
    
    NSString *fileName = @"SampleWordDocument.docx";
    [self uploadFile:fileName];
    
    XCTestExpectation *expectation = [self expectationWithDescription:@""];
    
    [self.wordsApi getDocumentWithCompletionBlock:fileName
                                          storage:nil
                                           folder:nil
                                completionHandler:^(ASPDocumentResponse *output, NSError *error) {
                                              XCTAssertNotNil(output, @"Failed to read document common info");
                                              XCTAssertEqualObjects(output.status, @"OK");
                                              [expectation fulfill];
                                }];
    
    [self waitForExpectationsWithTimeout:180.0 handler:^(NSError *error) {
        if (error) {
            NSLog(@"Timeout Error: %@", error);
        }
    }];
}

- (void)testGetDocumentWithFormat {
    
    NSString *fileName = @"SampleWordDocument.docx";
    [self uploadFile:fileName];
    
    XCTestExpectation *expectation = [self expectationWithDescription:@""];
    
    [self.wordsApi getDocumentWithFormatWithCompletionBlock:fileName
                                                     format:@"pdf"
                                                    storage:nil
                                                     folder:nil
                                                    outPath:nil
                                          completionHandler:^(NSURL *output, NSError *error) {
                                              XCTAssertNotNil(output, @"Failed to get document in desired format");
                                              [expectation fulfill];
                                          }];
 
    [self waitForExpectationsWithTimeout:180.0 handler:^(NSError *error) {
        if (error) {
            NSLog(@"Timeout Error: %@", error);
        }
    }];
}

- (void)testPostDocumentSaveAs {
    
    NSString *fileName = @"SampleWordDocument.docx";
    [self uploadFile:fileName];
    
    XCTestExpectation *expectation = [self expectationWithDescription:@""];
    
    ASPSaveOptionsData *saveOptions = [[ASPSaveOptionsData alloc] init];
    saveOptions.fileName = @"SampleWordDocument.pdf";
    saveOptions.saveFormat = @"pdf";
    
    [self.wordsApi postDocumentSaveAsWithCompletionBlock:fileName
                                         saveOptionsData:saveOptions
                                                 storage:nil
                                                  folder:nil
                                       completionHandler:^(ASPSaveResponse *output, NSError *error) {
                                           XCTAssertNotNil(output, @"Failed to Convert document to destination format with detailed settings and save result to storage.");
                                           [expectation fulfill];
                                       }];
    
    [self waitForExpectationsWithTimeout:180.0 handler:^(NSError *error) {
        if (error) {
            NSLog(@"Timeout Error: %@", error);
        }
    }];
}

- (void)testPutDocumentSaveAsTiff {
    
    NSString *fileName = @"SampleWordDocument.docx";
    [self uploadFile:fileName];
    
    XCTestExpectation *expectation = [self expectationWithDescription:@""];
    
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
                                              XCTAssertNotNil(output, @"Failed to convert document to tiff with detailed settings and save result to storage");
                                              [expectation fulfill];
                                          }];
 
    [self waitForExpectationsWithTimeout:180.0 handler:^(NSError *error) {
        if (error) {
            NSLog(@"Timeout Error: %@", error);
        }
    }];
}

- (void)testPostAppendDocument {
    
    NSString *fileName = @"SampleWordDocument.docx";
    [self uploadFile:fileName];
    
    XCTestExpectation *expectation = [self expectationWithDescription:@""];
    
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
                                           XCTAssertNotNil(output, @"Failed to append documents to original document");
                                           [expectation fulfill];
                                       }];
 
    [self waitForExpectationsWithTimeout:180.0 handler:^(NSError *error) {
        if (error) {
            NSLog(@"Timeout Error: %@", error);
        }
    }];
}

- (void)testGetDocumentBookmarks {
    
    NSString *fileName = @"SampleWordDocument.docx";
    [self uploadFile:fileName];
    
    XCTestExpectation *expectation = [self expectationWithDescription:@""];
 
    [self.wordsApi getDocumentBookmarksWithCompletionBlock:fileName
                                                   storage:nil
                                                    folder:nil
                                         completionHandler:^(ASPBookmarksResponse *output, NSError *error) {
                                             XCTAssertNotNil(output, @"Failed to read document bookmarks common info");
                                             [expectation fulfill];
                                         }];
 
    [self waitForExpectationsWithTimeout:180.0 handler:^(NSError *error) {
        if (error) {
            NSLog(@"Timeout Error: %@", error);
        }
    }];
}

- (void)testGetDocumentBookmarkByName {

    NSString *fileName = @"SampleWordDocument.docx";
    [self uploadFile:fileName];
    
    XCTestExpectation *expectation = [self expectationWithDescription:@""];
    
    [self.wordsApi getDocumentBookmarkByNameWithCompletionBlock:fileName
                                                   bookmarkName:@"aspose"
                                                        storage:nil
                                                         folder:nil
                                              completionHandler:^(ASPBookmarkResponse *output, NSError *error) {
                                                  XCTAssertNotNil(output, @"Failed to read document bookmark data by its name");
                                                  XCTAssertEqualObjects(output.status, @"OK");
                                                  [expectation fulfill];
                                              }];
 
    [self waitForExpectationsWithTimeout:180.0 handler:^(NSError *error) {
        if (error) {
            NSLog(@"Timeout Error: %@", error);
        }
    }];
}

- (void)testPostUpdateDocumentBookmark {
    
    NSString *fileName = @"SampleWordDocument.docx";
    [self uploadFile:fileName];
    
    XCTestExpectation *expectation = [self expectationWithDescription:@""];
    
    ASPBookmarkData *bookmarkData = [[ASPBookmarkData alloc] init];
    bookmarkData.name = @"aspose";
    bookmarkData.text = @"Bookmark is very good";
    
    [self.wordsApi postUpdateDocumentBookmarkWithCompletionBlock:fileName
                                                    bookmarkName:@"aspose"
                                                    bookmarkData:bookmarkData
                                                        filename:nil
                                                         storage:nil
                                                          folder:nil
                                               completionHandler:^(ASPBookmarkResponse *output, NSError *error) {
                                                   XCTAssertNotNil(output, @"Failed to update document bookmark");
                                                   XCTAssertEqualObjects(output.status, @"OK");
                                                   [expectation fulfill];
                                               }];
    
    [self waitForExpectationsWithTimeout:180.0 handler:^(NSError *error) {
        if (error) {
            NSLog(@"Timeout Error: %@", error);
        }
    }];
}

- (void)testGetComments {
    
    NSString *fileName = @"SampleWordDocument.docx";
    [self uploadFile:fileName];
    
    XCTestExpectation *expectation = [self expectationWithDescription:@""];
 
    [self.wordsApi getCommentsWithCompletionBlock:fileName
                                          storage:nil
                                           folder:nil
                                completionHandler:^(ASPCommentsResponse *output, NSError *error) {
                                    XCTAssertNotNil(output, @"Failed to get comments from document");
                                    XCTAssertEqualObjects(output.status, @"OK");
                                    [expectation fulfill];
                                }];
 
    [self waitForExpectationsWithTimeout:180.0 handler:^(NSError *error) {
        if (error) {
            NSLog(@"Timeout Error: %@", error);
        }
    }];
}

- (void)testPutComment {
    
    NSString *fileName = @"SampleWordDocument.docx";
    [self uploadFile:fileName];
    
    XCTestExpectation *expectation = [self expectationWithDescription:@""];
    
    ASPComment *comment = [[ASPComment alloc] init];
    comment.author = @"Adam";
    comment.text = @"Machine Learning";
    comment.initial = @"MS";
    
    comment.content = [[ASPStoryChildNodes alloc] init];
    comment.content.childNodes = (NSArray<ASPSystemObject>* ) @[];
    
    comment.rangeStart = [[ASPDocumentPosition alloc] init];
    comment.rangeStart.node = [[ASPNodeLink alloc] init];
    comment.rangeStart.node.nodeId = @"0.7.6";
    comment.rangeStart.offset = [NSNumber numberWithInt:0];
    
    comment.rangeEnd = [[ASPDocumentPosition alloc] init];
    comment.rangeEnd.node = [[ASPNodeLink alloc] init];
    comment.rangeEnd.node.nodeId = @"0.7.5";
    comment.rangeEnd.offset = [NSNumber numberWithInt:0];
    
    [self.wordsApi putCommentWithCompletionBlock:fileName
                                         comment:comment
                                        fileName:nil
                                         storage:nil
                                          folder:nil
                               completionHandler:^(ASPCommentResponse *output, NSError *error) {
                                   XCTAssertNotNil(output, @"Failed to add comment to document");
                                   XCTAssertEqualObjects(output.status, @"OK");
                                   [expectation fulfill];
                               }];
 
    [self waitForExpectationsWithTimeout:180.0 handler:^(NSError *error) {
        if (error) {
            NSLog(@"Timeout Error: %@", error);
        }
    }];
}

- (void)testGetComment {
    
    NSString *fileName = @"SampleWordDocument.docx";
    [self uploadFile:fileName];
    
    XCTestExpectation *expectation = [self expectationWithDescription:@""];
 
    [self.wordsApi getCommentWithCompletionBlock:fileName
                                    commentIndex:[NSNumber numberWithInt:0]
                                         storage:nil
                                          folder:nil
                               completionHandler:^(ASPCommentResponse *output, NSError *error) {
                                   XCTAssertNotNil(output, @"Failed to get comment from document");
                                   XCTAssertEqualObjects(output.status, @"OK");
                                   [expectation fulfill];
                               }];
 
    [self waitForExpectationsWithTimeout:180.0 handler:^(NSError *error) {
        if (error) {
            NSLog(@"Timeout Error: %@", error);
        }
    }];
}

- (void)testPostComment {
    
    NSString *fileName = @"SampleWordDocument.docx";
    [self uploadFile:fileName];
    
    XCTestExpectation *expectation = [self expectationWithDescription:@""];
    
    ASPComment *comment = [[ASPComment alloc] init];
    comment.author = @"Adam";
    comment.text = @"Machine Learning";
    
    comment.content = [[ASPStoryChildNodes alloc] init];
    comment.content.childNodes = (NSArray<ASPSystemObject>* ) @[];
    
    comment.rangeStart = [[ASPDocumentPosition alloc] init];
    comment.rangeStart.node = [[ASPNodeLink alloc] init];
    comment.rangeStart.node.nodeId = @"0.1.6";
    comment.rangeStart.offset = [NSNumber numberWithInt:0];
    
    comment.rangeEnd = [[ASPDocumentPosition alloc] init];
    comment.rangeEnd.node = [[ASPNodeLink alloc] init];
    comment.rangeEnd.node.nodeId = @"0.1.5";
    comment.rangeEnd.offset = [NSNumber numberWithInt:0];
    
    [self.wordsApi postCommentWithCompletionBlock:fileName
                                     commentIndex:[NSNumber numberWithInt:0]
                                          comment:comment
                                         fileName:nil
                                          storage:nil
                                           folder:nil
                                completionHandler:^(ASPCommentResponse *output, NSError *error) {
                                   XCTAssertNotNil(output, @"Failed to updates the comment");
                                   XCTAssertEqualObjects(output.status, @"OK");
                                   [expectation fulfill];
                               }];
    
    [self waitForExpectationsWithTimeout:180.0 handler:^(NSError *error) {
        if (error) {
            NSLog(@"Timeout Error: %@", error);
        }
    }];
}

- (void)testDeleteComment {
    
    NSString *fileName = @"SampleWordDocument.docx";
    [self uploadFile:fileName];
    
    XCTestExpectation *expectation = [self expectationWithDescription:@""];
    
    [self.wordsApi deleteCommentWithCompletionBlock:fileName
                                       commentIndex:[NSNumber numberWithInt:0]
                                            storage:nil
                                             folder:nil
                                           fileName:nil
                                  completionHandler:^(ASPBaseResponse *output, NSError *error) {
                                      XCTAssertNotNil(output, @"Failed to remove comment from document");
                                      XCTAssertEqualObjects(output.status, @"OK");
                                      [expectation fulfill];
                                  }];
    
    [self waitForExpectationsWithTimeout:180.0 handler:^(NSError *error) {
        if (error) {
            NSLog(@"Timeout Error: %@", error);
        }
    }];
}

- (void)testGetDocumentProperties {
    
    NSString *fileName = @"SampleWordDocument.docx";
    [self uploadFile:fileName];
    
    XCTestExpectation *expectation = [self expectationWithDescription:@""];
    
    [self.wordsApi getDocumentPropertiesWithCompletionBlock:fileName
                                                    storage:nil
                                                     folder:nil
                                          completionHandler:^(ASPDocumentPropertiesResponse *output, NSError *error) {
                                              XCTAssertNotNil(output, @"Failed to read document properties info");
                                              XCTAssertEqualObjects(output.status, @"OK");
                                              [expectation fulfill];
                                          }];
    
    [self waitForExpectationsWithTimeout:180.0 handler:^(NSError *error) {
        if (error) {
            NSLog(@"Timeout Error: %@", error);
        }
    }];
}

- (void)testGetDocumentProperty {
    
    NSString *fileName = @"SampleWordDocument.docx";
    [self uploadFile:fileName];
    
    XCTestExpectation *expectation = [self expectationWithDescription:@""];
    
    [self.wordsApi getDocumentPropertyWithCompletionBlock:fileName
                                             propertyName:@"Author"
                                                  storage:nil
                                                   folder:nil
                                        completionHandler:^(ASPDocumentPropertyResponse *output, NSError *error) {
                                            XCTAssertNotNil(output, @"Failed to read document property info by the property name");
                                            XCTAssertEqualObjects(output.status, @"OK");
                                            [expectation fulfill];
                                        }];
    
    [self waitForExpectationsWithTimeout:180.0 handler:^(NSError *error) {
        if (error) {
            NSLog(@"Timeout Error: %@", error);
        }
    }];
}

- (void)testPutUpdateDocumentProperty {
    
    NSString *fileName = @"SampleWordDocument.docx";
    [self uploadFile:fileName];
    
    XCTestExpectation *expectation = [self expectationWithDescription:@""];
    
    ASPDocumentProperty *property = [[ASPDocumentProperty alloc] init];
    property.name = @"Provider";
    property.value = @"Jobs";
    
    [self.wordsApi putUpdateDocumentPropertyWithCompletionBlock:fileName
                                                   propertyName:@"Provider"
                                                      _property:property
                                                       filename:nil
                                                        storage:nil
                                                         folder:nil
                                              completionHandler:^(ASPDocumentPropertyResponse *output, NSError *error) {
                                                  XCTAssertNotNil(output, @"Failed to update existing document property");
                                                  XCTAssertEqualObjects(output.status, @"OK");
                                                  [expectation fulfill];
                                              }];
    
    [self waitForExpectationsWithTimeout:180.0 handler:^(NSError *error) {
        if (error) {
            NSLog(@"Timeout Error: %@", error);
        }
    }];
}

- (void)testDeleteDocumentProperty {
    
    NSString *fileName = @"SampleWordDocument.docx";
   [self uploadFile:fileName];
    
    XCTestExpectation *expectation = [self expectationWithDescription:@""];
    
    [self.wordsApi deleteDocumentPropertyWithCompletionBlock:fileName
                                                propertyName:@"Provider"
                                                    filename:nil
                                                     storage:nil
                                                      folder:nil
                                           completionHandler:^(ASPBaseResponse *output, NSError *error) {
                                               XCTAssertNotNil(output, @"Failed to delete document property");
                                               XCTAssertEqualObjects(output.status, @"OK");
                                               [expectation fulfill];
                                           }];
    
    [self waitForExpectationsWithTimeout:180.0 handler:^(NSError *error) {
        if (error) {
            NSLog(@"Timeout Error: %@", error);
        }
    }];
}

- (void)testGetDocumentDrawingObjects {
    
    NSString *fileName = @"SampleWordDocument.docx";
    [self uploadFile:fileName];
    
    XCTestExpectation *expectation = [self expectationWithDescription:@""];
    
    [self.wordsApi getDocumentDrawingObjectsWithCompletionBlock:fileName
                                                        storage:nil
                                                         folder:nil
                                              completionHandler:^(ASPDrawingObjectsResponse *output, NSError *error) {
                                                  XCTAssertNotNil(output, @"Failed to read document drawing objects common info");
                                                  XCTAssertEqualObjects(output.status, @"OK");
                                                  [expectation fulfill];
                                              }];
    
    [self waitForExpectationsWithTimeout:180.0 handler:^(NSError *error) {
        if (error) {
            NSLog(@"Timeout Error: %@", error);
        }
    }];
}

- (void)testGetDocumentDrawingObjectByIndex {
    
    NSString *fileName = @"SampleWordDocument.docx";
    [self uploadFile:fileName];
    
    XCTestExpectation *expectation = [self expectationWithDescription:@""];
    
    [self.wordsApi getDocumentDrawingObjectByIndexWithCompletionBlock:fileName
                                                          objectIndex:[NSNumber numberWithInt:1]
                                                              storage:nil
                                                               folder:nil
                                                    completionHandler:^(ASPDrawingObjectResponse *output, NSError *error) {
                                                        XCTAssertNotNil(output, @"Failed to read document drawing object common info by its index");
                                                        XCTAssertEqualObjects(output.status, @"OK");
                                                        [expectation fulfill];
                                                    }];
    
    [self waitForExpectationsWithTimeout:180.0 handler:^(NSError *error) {
        if (error) {
            NSLog(@"Timeout Error: %@", error);
        }
    }];
}

- (void)testGetDocumentDrawingObjectByIndexWithFormat {
    
    NSString *fileName = @"SampleWordDocument.docx";
    [self uploadFile:fileName];
    
    XCTestExpectation *expectation = [self expectationWithDescription:@""];
    
    [self.wordsApi getDocumentDrawingObjectByIndexWithFormatWithCompletionBlock:fileName
                                                                    objectIndex:[NSNumber numberWithInt:1]
                                                                         format:@"png"
                                                                        storage:nil
                                                                         folder:nil
                                                              completionHandler:^(NSURL *output, NSError *error) {
                                                                  XCTAssertNotNil(output, @"Failed to get document drawing object");
                                                                  [expectation fulfill];
                                                              }];
    
    [self waitForExpectationsWithTimeout:180.0 handler:^(NSError *error) {
        if (error) {
            NSLog(@"Timeout Error: %@", error);
        }
    }];
}

- (void)testGetDocumentDrawingObjectImageData {
    
    NSString *fileName = @"SampleWordDocument.docx";
    [self uploadFile:fileName];
    
    XCTestExpectation *expectation = [self expectationWithDescription:@""];
    
    [self.wordsApi getDocumentDrawingObjectImageDataWithCompletionBlock:fileName
                                                            objectIndex:[NSNumber numberWithInt:1]
                                                                storage:nil
                                                                 folder:nil
                                                      completionHandler:^(NSURL *output, NSError *error) {
                                                          XCTAssertNotNil(output, @"Failed to read drawing object image data");
                                                          [expectation fulfill];
                                                      }];
    
    [self waitForExpectationsWithTimeout:180.0 handler:^(NSError *error) {
        if (error) {
            NSLog(@"Timeout Error: %@", error);
        }
    }];
}

- (void)testGetDocumentDrawingObjectOleData {
    
    NSString *fileName = @"Sample_EmbeddedOLE.docx";
    [self uploadFile:fileName];
    
    XCTestExpectation *expectation = [self expectationWithDescription:@""];
    
    [self.wordsApi getDocumentDrawingObjectOleDataWithCompletionBlock:fileName
                                                          objectIndex:[NSNumber numberWithInt:0]
                                                              storage:nil
                                                               folder:nil
                                                    completionHandler:^(NSURL *output, NSError *error) {
                                                        XCTAssertNotNil(output, @"Failed to get drawing object OLE data");
                                                        [expectation fulfill];
                                                    }];
    
    [self waitForExpectationsWithTimeout:180.0 handler:^(NSError *error) {
        if (error) {
            NSLog(@"Timeout Error: %@", error);
        }
    }];
}

- (void)testPostDocumentExecuteMailMerge {
    
    NSString *fileName = @"SampleMailMergeTemplateImage.doc";
    [self uploadFile:fileName];
    
    NSURL *pathToFile = [[NSBundle mainBundle] URLForResource:@"SampleMailMergeTemplateImageData" withExtension:@"txt"];
    
    XCTestExpectation *expectation = [self expectationWithDescription:@""];
    
    [self.wordsApi postDocumentExecuteMailMergeWithCompletionBlock:fileName
                                                       withRegions:[NSNumber numberWithBool:NO]
                                                              file:pathToFile
                                                 mailMergeDataFile:nil
                                                           cleanup:nil
                                                          filename:nil
                                                           storage:nil
                                                            folder:nil
                                         useWholeParagraphAsRegion:nil
                                                 completionHandler:^(ASPDocumentResponse *output, NSError *error) {
                                                     XCTAssertNotNil(output, @"Failed to execute document mail merge operation");
                                                     XCTAssertEqualObjects(output.status, @"OK");
                                                     [expectation fulfill];
                                        }];
    
    [self waitForExpectationsWithTimeout:180.0 handler:^(NSError *error) {
        if (error) {
            NSLog(@"Timeout Error: %@", error);
        }
    }];
}

- (void)testPostExecuteTemplate {
    
    NSString *fileName = @"SampleExecuteTemplate.doc";
    [self uploadFile:fileName];
    
    XCTestExpectation *expectation = [self expectationWithDescription:@""];
    
    NSURL *pathToFile = [[NSBundle mainBundle] URLForResource:@"SampleExecuteTemplateData" withExtension:@"txt"];
    
    [self.wordsApi postExecuteTemplateWithCompletionBlock:fileName
                                                     file:pathToFile
                                                  cleanup:nil
                                                 filename:nil
                                                  storage:nil
                                                   folder:nil
                                useWholeParagraphAsRegion:nil
                                              withRegions:nil
                                        completionHandler:^(ASPDocumentResponse *output, NSError *error) {
                                            XCTAssertNotNil(output, @"Failed to populate document template with data");
                                            XCTAssertEqualObjects(output.status, @"OK");
                                            [expectation fulfill];
                                }];
    
    [self waitForExpectationsWithTimeout:180.0 handler:^(NSError *error) {
        if (error) {
            NSLog(@"Timeout Error: %@", error);
        }
    }];
}

- (void)testDeleteDocumentFields {
    
    NSString *fileName = @"SampleWordDocument.docx";
    [self uploadFile:fileName];
    
    XCTestExpectation *expectation = [self expectationWithDescription:@""];
    
    [self.wordsApi deleteDocumentFieldsWithCompletionBlock:fileName
                                                   storage:nil
                                                    folder:nil
                                         completionHandler:^(ASPBaseResponse *output, NSError *error) {
                                             XCTAssertNotNil(output, @"Failed to remove fields from document");
                                             XCTAssertEqualObjects(output.status, @"OK");
                                             [expectation fulfill];
                                         }];
    
    [self waitForExpectationsWithTimeout:180.0 handler:^(NSError *error) {
        if (error) {
            NSLog(@"Timeout Error: %@", error);
        }
    }];
}

- (void)testDeleteHeadersFooters {
    
    NSString *fileName = @"SampleWordDocument.docx";
    [self uploadFile:fileName];
    
    XCTestExpectation *expectation = [self expectationWithDescription:@""];
    
    [self.wordsApi deleteHeadersFootersWithCompletionBlock:fileName
                                       headersFootersTypes:nil
                                                  filename:nil
                                                   storage:nil
                                                    folder:nil
                                         completionHandler:^(ASPBaseResponse *output, NSError *error) {
                                             XCTAssertNotNil(output, @"Failed to delete document headers and footers");
                                             XCTAssertEqualObjects(output.status, @"OK");
                                             [expectation fulfill];
                                         }];
    
    [self waitForExpectationsWithTimeout:180.0 handler:^(NSError *error) {
        if (error) {
            NSLog(@"Timeout Error: %@", error);
        }
    }];
}

- (void)testGetDocumentHyperlinks {
    
    NSString *fileName = @"SampleWordDocument.docx";
    [self uploadFile:fileName];
    
    XCTestExpectation *expectation = [self expectationWithDescription:@""];
    
    [self.wordsApi getDocumentHyperlinksWithCompletionBlock:fileName
                                                    storage:nil
                                                     folder:nil
                                          completionHandler:^(ASPHyperlinksResponse *output, NSError *error) {
                                              XCTAssertNotNil(output, @"Failed to read document hyperlinks common info");
                                              XCTAssertEqualObjects(output.status, @"OK");
                                              [expectation fulfill];
                                          }];
    
    [self waitForExpectationsWithTimeout:180.0 handler:^(NSError *error) {
        if (error) {
            NSLog(@"Timeout Error: %@", error);
        }
    }];
}

- (void)testGetDocumentHyperlinkByIndex {
    
    NSString *fileName = @"SampleWordDocument.docx";
    [self uploadFile:fileName];
    
    XCTestExpectation *expectation = [self expectationWithDescription:@""];
    
    [self.wordsApi getDocumentHyperlinkByIndexWithCompletionBlock:fileName
                                                   hyperlinkIndex:[NSNumber numberWithInt:0]
                                                          storage:nil
                                                           folder:nil
                                                completionHandler:^(ASPHyperlinkResponse *output, NSError *error) {
                                                    XCTAssertNotNil(output, @"Failed to read document hyperlink by its index");
                                                    XCTAssertEqualObjects(output.status, @"OK");
                                                    [expectation fulfill];
                                                }];
    
    [self waitForExpectationsWithTimeout:180.0 handler:^(NSError *error) {
        if (error) {
            NSLog(@"Timeout Error: %@", error);
        }
    }];
}

- (void)testPostInsertPageNumbers {
    
    NSString *fileName = @"SampleWordDocument.docx";
    [self uploadFile:fileName];
    
    XCTestExpectation *expectation = [self expectationWithDescription:@""];
    
    ASPPageNumber *pagenumber = [[ASPPageNumber alloc] init];
    pagenumber.format = @"{PAGE} of {NUMPAGES}";
    pagenumber.alignment = @"center";
    
    [self.wordsApi postInsertPageNumbersWithCompletionBlock:fileName
                                                 pageNumber:pagenumber
                                                   filename:nil
                                                    storage:nil
                                                     folder:nil
                                          completionHandler:^(ASPDocumentResponse *output, NSError *error) {
                                              XCTAssertNotNil(output, @"Failed to insert document page numbers");
                                              XCTAssertEqualObjects(output.status, @"OK");
                                              [expectation fulfill];
                                          }];
    
    [self waitForExpectationsWithTimeout:180.0 handler:^(NSError *error) {
        if (error) {
            NSLog(@"Timeout Error: %@", error);
        }
    }];
}

- (void)testPostInsertWatermarkImage {
    
    NSString *fileName = @"SampleWordDocument.docx";
    [self uploadFile:fileName];
    
    XCTestExpectation *expectation = [self expectationWithDescription:@""];
    
    [self.wordsApi postInsertWatermarkImageWithCompletionBlock:fileName
                                                      filename:nil
                                                 rotationAngle:[NSNumber numberWithDouble:45]
                                                         image:@"aspose-cloud.png"
                                                       storage:nil
                                                        folder:nil
                                             completionHandler:^(ASPDocumentResponse *output, NSError *error) {
                                                 XCTAssertNotNil(output, @"Failed to insert document watermark image");
                                                 XCTAssertEqualObjects(output.status, @"OK");
                                                 [expectation fulfill];
                                             }];
    
    [self waitForExpectationsWithTimeout:180.0 handler:^(NSError *error) {
        if (error) {
            NSLog(@"Timeout Error: %@", error);
        }
    }];
}

- (void)testPostInsertWatermarkText {
    
    NSString *fileName = @"SampleWordDocument.docx";
    [self uploadFile:fileName];
    
    XCTestExpectation *expectation = [self expectationWithDescription:@""];
    
    ASPWatermarkText *watermarkText = [[ASPWatermarkText alloc] init];
    watermarkText.text = @"Welcome Aspose";
    watermarkText.rotationAngle = [NSNumber numberWithDouble:45];
    
    [self.wordsApi postInsertWatermarkTextWithCompletionBlock:fileName
                                                watermarkText:watermarkText
                                                         text:nil
                                                rotationAngle:nil
                                                     filename:nil
                                                      storage:nil
                                                       folder:nil
                                            completionHandler:^(ASPDocumentResponse *output, NSError *error) {
                                                XCTAssertNotNil(output, @"Failed to insert document watermark text");
                                                XCTAssertEqualObjects(output.status, @"OK");
                                                [expectation fulfill];
                                            }];
    
    [self waitForExpectationsWithTimeout:180.0 handler:^(NSError *error) {
        if (error) {
            NSLog(@"Timeout Error: %@", error);
        }
    }];
}

- (void)testDeleteDocumentMacros {
    
    NSString *fileName = @"SampleWordDocument.docx";
    [self uploadFile:fileName];
    
    XCTestExpectation *expectation = [self expectationWithDescription:@""];
    
    [self.wordsApi deleteDocumentMacrosWithCompletionBlock:fileName
                                                   storage:nil
                                                    folder:nil
                                         completionHandler:^(ASPBaseResponse *output, NSError *error) {
                                             XCTAssertNotNil(output, @"Failed to remove macros from document");
                                             XCTAssertEqualObjects(output.status, @"OK");
                                             [expectation fulfill];
                                         }];
    
    [self waitForExpectationsWithTimeout:180.0 handler:^(NSError *error) {
        if (error) {
            NSLog(@"Timeout Error: %@", error);
        }
    }];
}

- (void)testGetDocumentFieldNames {
    
    NSString *fileName = @"SampleWordDocument.docx";
    [self uploadFile:fileName];
    
    XCTestExpectation *expectation = [self expectationWithDescription:@""];
    
    [self.wordsApi getDocumentFieldNamesWithCompletionBlock:fileName
                                          useNonMergeFields:nil
                                                    storage:nil
                                                     folder:nil
                                          completionHandler:^(ASPFieldNamesResponse *output, NSError *error) {
                                              XCTAssertNotNil(output, @"Failed to read document field names");
                                              XCTAssertEqualObjects(output.status, @"OK");
                                              [expectation fulfill];
                                          }];
    
    [self waitForExpectationsWithTimeout:180.0 handler:^(NSError *error) {
        if (error) {
            NSLog(@"Timeout Error: %@", error);
        }
    }];
}

- (void)testGetDocumentParagraphs {
    
    NSString *fileName = @"SampleWordDocument.docx";
    [self uploadFile:fileName];
    
    XCTestExpectation *expectation = [self expectationWithDescription:@""];
    
    [self.wordsApi getDocumentParagraphsWithCompletionBlock:fileName
                                                    storage:nil
                                                     folder:nil
                                          completionHandler:^(ASPParagraphLinkCollectionResponse *output, NSError *error) {
                                              XCTAssertNotNil(output, @"Failed to return a list of paragraphs that are contained in the document");
                                              XCTAssertEqualObjects(output.status, @"OK");
                                              [expectation fulfill];
                                          }];
    
    [self waitForExpectationsWithTimeout:180.0 handler:^(NSError *error) {
        if (error) {
            NSLog(@"Timeout Error: %@", error);
        }
    }];
}

- (void)testGetDocumentParagraph {
    
    NSString *fileName = @"SampleWordDocument.docx";
    [self uploadFile:fileName];
    
    XCTestExpectation *expectation = [self expectationWithDescription:@""];
    
    [self.wordsApi getDocumentParagraphWithCompletionBlock:fileName
                                                     index:[NSNumber numberWithInt:1]
                                                   storage:nil
                                                    folder:nil
                                         completionHandler:^(ASPParagraphResponse *output, NSError *error) {
                                             XCTAssertNotNil(output, @"Failed to get paragraph contained in the document");
                                             XCTAssertEqualObjects(output.status, @"OK");
                                             [expectation fulfill];
                                         }];
    
    [self waitForExpectationsWithTimeout:180.0 handler:^(NSError *error) {
        if (error) {
            NSLog(@"Timeout Error: %@", error);
        }
    }];
}

- (void)testDeleteParagraphFields {
    
    NSString *fileName = @"SampleWordDocument.docx";
    [self uploadFile:fileName];
    
    XCTestExpectation *expectation = [self expectationWithDescription:@""];
    
    [self.wordsApi deleteParagraphFieldsWithCompletionBlock:fileName
                                                      index:[NSNumber numberWithInt:0]
                                                    storage:nil
                                                     folder:nil
                                          completionHandler:^(ASPBaseResponse *output, NSError *error) {
                                              XCTAssertNotNil(output, @"Failed to remove fields from paragraph");
                                              XCTAssertEqualObjects(output.status, @"OK");
                                              [expectation fulfill];
                                          }];
    
    [self waitForExpectationsWithTimeout:180.0 handler:^(NSError *error) {
        if (error) {
            NSLog(@"Timeout Error: %@", error);
        }
    }];
}

- (void)testGetDocumentParagraphRun {
    
    NSString *fileName = @"SampleWordDocument.docx";
    [self uploadFile:fileName];
    
    XCTestExpectation *expectation = [self expectationWithDescription:@""];
    
    [self.wordsApi getDocumentParagraphRunWithCompletionBlock:fileName
                                                        index:[NSNumber numberWithInt:0]
                                                     runIndex:[NSNumber numberWithInt:0]
                                                      storage:nil
                                                       folder:nil
                                            completionHandler:^(ASPRunResponse *output, NSError *error) {
                                                XCTAssertNotNil(output, @"Failed to get a paragraph contained in the document");
                                                XCTAssertEqualObjects(output.status, @"OK");
                                                [expectation fulfill];
                                            }];
    
    [self waitForExpectationsWithTimeout:180.0 handler:^(NSError *error) {
        if (error) {
            NSLog(@"Timeout Error: %@", error);
        }
    }];
}

- (void)testGetDocumentParagraphRunFont {
    
    NSString *fileName = @"SampleWordDocument.docx";
    [self uploadFile:fileName];
    
    XCTestExpectation *expectation = [self expectationWithDescription:@""];
    
    [self.wordsApi getDocumentParagraphRunFontWithCompletionBlock:fileName
                                                            index:[NSNumber numberWithInt:0]
                                                         runIndex:[NSNumber numberWithInt:0]
                                                          storage:nil
                                                           folder:nil
                                                completionHandler:^(ASPFontResponse *output, NSError *error) {
                                                    XCTAssertNotNil(output, @"Failed to get a paragraph contained in the document");
                                                    XCTAssertEqualObjects(output.status, @"OK");
                                                    [expectation fulfill];
                                                }];
    
    [self waitForExpectationsWithTimeout:180.0 handler:^(NSError *error) {
        if (error) {
            NSLog(@"Timeout Error: %@", error);
        }
    }];
}

- (void)testPostDocumentParagraphRunFont {
    
    NSString *fileName = @"SampleWordDocument.docx";
    [self uploadFile:fileName];
    
    XCTestExpectation *expectation = [self expectationWithDescription:@""];
    
    ASPFont *font = [[ASPFont alloc] init];
    font.name = @"Arial";
    font.bold = [NSNumber numberWithBool:YES];
    
    [self.wordsApi postDocumentParagraphRunFontWithCompletionBlock:fileName
                                                             index:[NSNumber numberWithInt:0]
                                                          runIndex:[NSNumber numberWithInt:0]
                                                              font:font
                                                           storage:nil
                                                            folder:nil
                                                          filename:nil
                                                 completionHandler:^(ASPFontResponse *output, NSError *error) {
                                                     XCTAssertNotNil(output, @"Failed to post document paragraph run font");
                                                     XCTAssertEqualObjects(output.status, @"OK");
                                                     [expectation fulfill];
                                                 }];
    
    [self waitForExpectationsWithTimeout:180.0 handler:^(NSError *error) {
        if (error) {
            NSLog(@"Timeout Error: %@", error);
        }
    }];
}

- (void)testGetDocumentProtection {
    
    NSString *fileName = @"SampleWordDocument.docx";
    [self uploadFile:fileName];
    
    XCTestExpectation *expectation = [self expectationWithDescription:@""];
    
    [self.wordsApi getDocumentProtectionWithCompletionBlock:fileName
                                                    storage:nil
                                                     folder:nil
                                          completionHandler:^(ASPProtectionDataResponse *output, NSError *error) {
                                              XCTAssertNotNil(output, @"Failed to read document protection common info");
                                              XCTAssertEqualObjects(output.status, @"OK");
                                              [expectation fulfill];
                                          }];
    
    [self waitForExpectationsWithTimeout:180.0 handler:^(NSError *error) {
        if (error) {
            NSLog(@"Timeout Error: %@", error);
        }
    }];
}

- (void)testPutProtectDocument {
    
    NSString *fileName = @"SampleWordDocument.docx";
    [self uploadFile:fileName];
    
    XCTestExpectation *expectation = [self expectationWithDescription:@""];
    
    ASPProtectionRequest *protectionData = [[ASPProtectionRequest alloc] init];
    protectionData.password = @"myPassword";
    
    [self.wordsApi putProtectDocumentWithCompletionBlock:fileName
                                       protectionRequest:protectionData
                                                filename:nil
                                                 storage:nil
                                                  folder:nil
                                       completionHandler:^(ASPProtectionDataResponse *output, NSError *error) {
                                           XCTAssertNotNil(output, @"Failed to protect document");
                                           XCTAssertEqualObjects(output.status, @"OK");
                                           [expectation fulfill];
                                       }];
    
    [self waitForExpectationsWithTimeout:180.0 handler:^(NSError *error) {
        if (error) {
            NSLog(@"Timeout Error: %@", error);
        }
    }];
}

- (void)testPostChangeDocumentProtection {
    
    NSString *fileName = @"SampleWordDocument.docx";
    [self uploadFile:fileName];
    
    XCTestExpectation *expectation = [self expectationWithDescription:@""];
    
    ASPProtectionRequest *protectionData = [[ASPProtectionRequest alloc] init];
    protectionData.password = @"newPassword";
    
    [self.wordsApi postChangeDocumentProtectionWithCompletionBlock:fileName
                                                 protectionRequest:protectionData
                                                          filename:nil
                                                           storage:nil
                                                            folder:nil
                                                 completionHandler:^(ASPProtectionDataResponse *output, NSError *error) {
                                                     XCTAssertNotNil(output, @"Failed to change document protection");
                                                     XCTAssertEqualObjects(output.status, @"OK");
                                                     [expectation fulfill];
                                                 }];
    
    [self waitForExpectationsWithTimeout:180.0 handler:^(NSError *error) {
        if (error) {
            NSLog(@"Timeout Error: %@", error);
        }
    }];
}

- (void)testDeleteUnprotectDocument {
    
    NSString *fileName = @"SampleWordDocument.docx";
    [self uploadFile:fileName];
    
    XCTestExpectation *expectation = [self expectationWithDescription:@""];
    
    ASPProtectionRequest *protectionData = [[ASPProtectionRequest alloc] init];
    protectionData.password = @"myPassword";
    
    [self.wordsApi deleteUnprotectDocumentWithCompletionBlock:fileName
                                            protectionRequest:protectionData
                                                     filename:nil
                                                      storage:nil
                                                       folder:nil
                                            completionHandler:^(ASPProtectionDataResponse *output, NSError *error) {
                                                XCTAssertNotNil(output, @"Failed to unprotect document");
                                                XCTAssertEqualObjects(output.status, @"OK");
                                                [expectation fulfill];
                                            }];
    
    [self waitForExpectationsWithTimeout:180.0 handler:^(NSError *error) {
        if (error) {
            NSLog(@"Timeout Error: %@", error);
        }
    }];
}

- (void)testPostReplaceText {
    
    NSString *fileName = @"SampleWordDocument.docx";
    [self uploadFile:fileName];
    
    XCTestExpectation *expectation = [self expectationWithDescription:@""];
    
    ASPReplaceTextRequest *replaceText = [[ASPReplaceTextRequest alloc] init];
    replaceText.oldValue = @"Times New Roman";
    replaceText.currentValue = @"Arial Black";
    
    [self.wordsApi postReplaceTextWithCompletionBlock:fileName
                                          replaceText:replaceText
                                             filename:nil
                                              storage:nil
                                               folder:nil
                                    completionHandler:^(ASPReplaceTextResponse *output, NSError *error) {
                                        XCTAssertNotNil(output, @"Failed to replace document text");
                                        XCTAssertEqualObjects(output.status, @"OK");
                                        [expectation fulfill];
                                    }];
    
    [self waitForExpectationsWithTimeout:180.0 handler:^(NSError *error) {
        if (error) {
            NSLog(@"Timeout Error: %@", error);
        }
    }];
}

- (void)testAcceptAllRevisions {
    
    NSString *fileName = @"SampleWordDocument.docx";
    [self uploadFile:fileName];
    
    XCTestExpectation *expectation = [self expectationWithDescription:@""];
    
    [self.wordsApi acceptAllRevisionsWithCompletionBlock:fileName
                                                filename:nil
                                                 storage:nil
                                                  folder:nil
                                       completionHandler:^(ASPRevisionsModificationResponse *output, NSError *error) {
                                           XCTAssertNotNil(output, @"Failed to accept all revisions in document");
                                           XCTAssertEqualObjects(output.status, @"OK");
                                           [expectation fulfill];
                                       }];
    
    [self waitForExpectationsWithTimeout:180.0 handler:^(NSError *error) {
        if (error) {
            NSLog(@"Timeout Error: %@", error);
        }
    }];
}

- (void)testRejectAllRevisions {
    
    NSString *fileName = @"SampleWordDocument.docx";
    [self uploadFile:fileName];
    
    XCTestExpectation *expectation = [self expectationWithDescription:@""];
    
    [self.wordsApi rejectAllRevisionsWithCompletionBlock:fileName
                                                filename:nil
                                                 storage:nil
                                                  folder:nil
                                       completionHandler:^(ASPRevisionsModificationResponse *output, NSError *error) {
                                           XCTAssertNotNil(output, @"Failed to reject all revisions in document");
                                           XCTAssertEqualObjects(output.status, @"OK");
                                           [expectation fulfill];
                                       }];
    
    [self waitForExpectationsWithTimeout:180.0 handler:^(NSError *error) {
        if (error) {
            NSLog(@"Timeout Error: %@", error);
        }
    }];
}

- (void)testGetWordsSearch {
    
    NSString *fileName = @"SampleWordDocument.docx";
    [self uploadFile:fileName];
    
    XCTestExpectation *expectation = [self expectationWithDescription:@""];
    
    [self.wordsApi getWordsSearchWithCompletionBlock:fileName
                                             pattern:@"mat"
                                             storage:nil
                                              folder:nil
                                   completionHandler:^(ASPSearchResponse *output, NSError *error) {
                                       XCTAssertNotNil(output, @"Failed to do words search");
                                       XCTAssertEqualObjects(output.status, @"OK");
                                       [expectation fulfill];
                                   }];
    
    [self waitForExpectationsWithTimeout:180.0 handler:^(NSError *error) {
        if (error) {
            NSLog(@"Timeout Error: %@", error);
        }
    }];
}

- (void)testGetSections {
    
    NSString *fileName = @"SampleWordDocument.docx";
    [self uploadFile:fileName];
    
    XCTestExpectation *expectation = [self expectationWithDescription:@""];
    
    [self.wordsApi getSectionsWithCompletionBlock:fileName
                                          storage:nil
                                           folder:nil
                                completionHandler:^(ASPSectionLinkCollectionResponse *output, NSError *error) {
                                    XCTAssertNotNil(output, @"Failed to get a list of sections that are contained in the document");
                                    XCTAssertEqualObjects(output.status, @"OK");
                                    [expectation fulfill];
                                }];
    
    [self waitForExpectationsWithTimeout:180.0 handler:^(NSError *error) {
        if (error) {
            NSLog(@"Timeout Error: %@", error);
        }
    }];
}

- (void)testGetSection {
    
    NSString *fileName = @"SampleWordDocument.docx";
    [self uploadFile:fileName];
    
    XCTestExpectation *expectation = [self expectationWithDescription:@""];
    
    [self.wordsApi getSectionWithCompletionBlock:fileName
                                    sectionIndex:[NSNumber numberWithInt:0]
                                         storage:nil
                                          folder:nil
                               completionHandler:^(ASPSectionResponse *output, NSError *error) {
                                   XCTAssertNotNil(output, @"Failed to get document section by index");
                                   XCTAssertEqualObjects(output.status, @"OK");
                                   [expectation fulfill];
                               }];
    
    [self waitForExpectationsWithTimeout:180.0 handler:^(NSError *error) {
        if (error) {
            NSLog(@"Timeout Error: %@", error);
        }
    }];
}

- (void)testDeleteSectionFields {
    
    NSString *fileName = @"SampleWordDocument.docx";
    [self uploadFile:fileName];
    
    XCTestExpectation *expectation = [self expectationWithDescription:@""];
    
    [self.wordsApi deleteSectionFieldsWithCompletionBlock:fileName
                                             sectionIndex:[NSNumber numberWithInt:0]
                                                  storage:nil
                                                   folder:nil
                                        completionHandler:^(ASPBaseResponse *output, NSError *error) {
                                            XCTAssertNotNil(output, @"Failed to remove fields from section");
                                            XCTAssertEqualObjects(output.status, @"OK");
                                            [expectation fulfill];
                                        }];
    
    [self waitForExpectationsWithTimeout:180.0 handler:^(NSError *error) {
        if (error) {
            NSLog(@"Timeout Error: %@", error);
        }
    }];
}

- (void)testGetSectionPageSetup {
    
    NSString *fileName = @"SampleWordDocument.docx";
    [self uploadFile:fileName];
    
    XCTestExpectation *expectation = [self expectationWithDescription:@""];
    
    [self.wordsApi getSectionPageSetupWithCompletionBlock:fileName
                                             sectionIndex:[NSNumber numberWithInt:0]
                                                  storage:nil
                                                   folder:nil
                                        completionHandler:^(ASPSectionPageSetupResponse *output, NSError *error) {
                                            XCTAssertNotNil(output, @"Failed to get page setup of section");
                                            XCTAssertEqualObjects(output.status, @"OK");
                                            [expectation fulfill];
                                        }];
    
    [self waitForExpectationsWithTimeout:180.0 handler:^(NSError *error) {
        if (error) {
            NSLog(@"Timeout Error: %@", error);
        }
    }];
}

- (void)testUpdateSectionPageSetup {
    
    NSString *fileName = @"SampleWordDocument.docx";
    [self uploadFile:fileName];
    
    XCTestExpectation *expectation = [self expectationWithDescription:@""];
    
    ASPPageSetup *pageSetup = [[ASPPageSetup alloc] init];
    pageSetup.rtlGutter = [NSNumber numberWithBool:YES];
    pageSetup.leftMargin = [NSNumber numberWithDouble:10.0];
    pageSetup.orientation = @"Landscape";
    pageSetup.paperSize = @"A5";
    
    [self.wordsApi updateSectionPageSetupWithCompletionBlock:fileName
                                                sectionIndex:[NSNumber numberWithInt:0]
                                                   pageSetup:pageSetup
                                                     storage:nil
                                                      folder:nil
                                                    filename:nil
                                           completionHandler:^(ASPSectionPageSetupResponse *output, NSError *error) {
                                               XCTAssertNotNil(output, @"Failed to update page setup of section");
                                               XCTAssertEqualObjects(output.status, @"OK");
                                               [expectation fulfill];
                                           }];
    
    [self waitForExpectationsWithTimeout:180.0 handler:^(NSError *error) {
        if (error) {
            NSLog(@"Timeout Error: %@", error);
        }
    }];
}

- (void)testPutField {
    
    NSString *fileName = @"SampleWordDocument.docx";
    [self uploadFile:fileName];
    
    XCTestExpectation *expectation = [self expectationWithDescription:@""];
    
    ASPField *field = [[ASPField alloc] init];
    field.name = @"Info";
    field.values = @[@"Data Science"];
    
    [self.wordsApi putFieldWithCompletionBlock:fileName
                                  sectionIndex:[NSNumber numberWithInt:0]
                                paragraphIndex:[NSNumber numberWithInt:0]
                                         field:field
                              insertBeforeNode:nil
                                  destFileName:nil
                                       storage:nil
                                        folder:nil
                             completionHandler:^(ASPFieldResponse *output, NSError *error) {
                                 XCTAssertNotNil(output, @"Failed to add field");
                                 XCTAssertEqualObjects(output.status, @"OK");
                                 [expectation fulfill];
                             }];
    
    [self waitForExpectationsWithTimeout:180.0 handler:^(NSError *error) {
        if (error) {
            NSLog(@"Timeout Error: %@", error);
        }
    }];
}

- (void)testGetField {
    
    NSString *fileName = @"SampleWordDocument.docx";
    [self uploadFile:fileName];
    
    XCTestExpectation *expectation = [self expectationWithDescription:@""];
    
    [self.wordsApi getFieldWithCompletionBlock:fileName
                                  sectionIndex:[NSNumber numberWithInt:0]
                                paragraphIndex:[NSNumber numberWithInt:0]
                                    fieldIndex:[NSNumber numberWithInt:0]
                                       storage:nil
                                        folder:nil
                             completionHandler:^(ASPFieldResponse *output, NSError *error) {
                                 XCTAssertNotNil(output, @"Failed to get field");
                                 XCTAssertEqualObjects(output.status, @"OK");
                                 [expectation fulfill];
                             }];
    
    [self waitForExpectationsWithTimeout:180.0 handler:^(NSError *error) {
        if (error) {
            NSLog(@"Timeout Error: %@", error);
        }
    }];
}

- (void)testPostField {
    
    NSString *fileName = @"SampleWordDocument.docx";
    [self uploadFile:fileName];
    
    XCTestExpectation *expectation = [self expectationWithDescription:@""];
    
    ASPField *field = [[ASPField alloc] init];
    field.name = @"Info";
    field.values = @[@"Data Mining"];
    
    [self.wordsApi postFieldWithCompletionBlock:fileName
                                   sectionIndex:[NSNumber numberWithInt:0]
                                 paragraphIndex:[NSNumber numberWithInt:0]
                                     fieldIndex:[NSNumber numberWithInt:0]
                                          field:field
                                   destFileName:nil
                                        storage:nil
                                         folder:nil
                              completionHandler:^(ASPFieldResponse *output, NSError *error) {
                                  XCTAssertNotNil(output, @"Failed to update field");
                                  XCTAssertEqualObjects(output.status, @"OK");
                                  [expectation fulfill];
     }];
    
    [self waitForExpectationsWithTimeout:180.0 handler:^(NSError *error) {
        if (error) {
            NSLog(@"Timeout Error: %@", error);
        }
    }];
}

- (void)testPutFormField {
    
    NSString *fileName = @"FormFilled.docx";
    [self uploadFile:fileName];
    
    XCTestExpectation *expectation = [self expectationWithDescription:@""];
    
    ASPFormField *formField = [[ASPFormField alloc] init];
    formField.name = @"FullName";
    formField.statusText = @"Enter your name and surname (trimmed to 30 characters)";
    formField.enabled = [NSNumber numberWithBool:YES];
    
    [self.wordsApi putFormFieldWithCompletionBlock:fileName
                                      sectionIndex:[NSNumber numberWithInt:0]
                                    paragraphIndex:[NSNumber numberWithInt:0]
                                         formField:formField
                                  insertBeforeNode:nil
                                      destFileName:nil
                                           storage:nil
                                            folder:nil
                                 completionHandler:^(ASPFormFieldResponse *output, NSError *error) {
                                     XCTAssertNotNil(output, @"Failed to add form field to paragraph");
                                     XCTAssertEqualObjects(output.status, @"OK");
                                     [expectation fulfill];
                                 }];
    
    [self waitForExpectationsWithTimeout:180.0 handler:^(NSError *error) {
        if (error) {
            NSLog(@"Timeout Error: %@", error);
        }
    }];
}

- (void)testGetFormField {
    
    NSString *fileName = @"FormFilled.docx";
    [self uploadFile:fileName];
    
    XCTestExpectation *expectation = [self expectationWithDescription:@""];
    
    [self.wordsApi getFormFieldWithCompletionBlock:fileName
                                      sectionIndex:[NSNumber numberWithInt:0]
                                    paragraphIndex:[NSNumber numberWithInt:0]
                                    formfieldIndex:[NSNumber numberWithInt:0]
                                           storage:nil
                                            folder:nil
                                 completionHandler:^(ASPFormFieldResponse *output, NSError *error) {
                                     XCTAssertNotNil(output, @"Failed to get a form field");
                                     XCTAssertEqualObjects(output.status, @"OK");
                                     [expectation fulfill];
                                 }];
    
    [self waitForExpectationsWithTimeout:180.0 handler:^(NSError *error) {
        if (error) {
            NSLog(@"Timeout Error: %@", error);
        }
    }];
}

- (void)testPostFormField {
    
    NSString *fileName = @"FormFilled.docx";
    [self uploadFile:fileName];
    
    XCTestExpectation *expectation = [self expectationWithDescription:@""];
    
    ASPFormField *formField = [[ASPFormField alloc] init];
    formField.name = @"CheckBox";
    formField.statusText = @"Helpful?";
    formField.enabled = [NSNumber numberWithBool:YES];
    
    [self.wordsApi postFormFieldWithCompletionBlock:fileName
                                       sectionIndex:[NSNumber numberWithInt:0]
                                     paragraphIndex:[NSNumber numberWithInt:0]
                                     formfieldIndex:[NSNumber numberWithInt:0]
                                          formField:formField
                                       destFileName:nil
                                            storage:nil
                                             folder:nil
                                  completionHandler:^(ASPFormFieldResponse *output, NSError *error) {
                                      XCTAssertNotNil(output, @"Failed to update form field's properties");
                                      XCTAssertEqualObjects(output.status, @"OK");
                                      [expectation fulfill];
     }];
    
    [self waitForExpectationsWithTimeout:180.0 handler:^(NSError *error) {
        if (error) {
            NSLog(@"Timeout Error: %@", error);
        }
    }];
}

- (void)testDeleteFormField {
    
    NSString *fileName = @"FormFilled.docx";
    [self uploadFile:fileName];
    
    XCTestExpectation *expectation = [self expectationWithDescription:@""];
    
    [self.wordsApi deleteFormFieldWithCompletionBlock:fileName
                                         sectionIndex:[NSNumber numberWithInt:0]
                                       paragraphIndex:[NSNumber numberWithInt:0]
                                       formfieldIndex:[NSNumber numberWithInt:0]
                                         destFileName:nil
                                              storage:nil
                                               folder:nil
                                    completionHandler:^(ASPBaseResponse *output, NSError *error) {
                                        XCTAssertNotNil(output, @"Failed to remove form field from document");
                                        XCTAssertEqualObjects(output.status, @"OK");
                                        [expectation fulfill];
                                    }];
    
    [self waitForExpectationsWithTimeout:180.0 handler:^(NSError *error) {
        if (error) {
            NSLog(@"Timeout Error: %@", error);
        }
    }];
}

- (void)testPostSplitDocument {
    
    NSString *fileName = @"SampleWordDocument.docx";
    [self uploadFile:fileName];
    
    XCTestExpectation *expectation = [self expectationWithDescription:@""];
    
    [self.wordsApi postSplitDocumentWithCompletionBlock:fileName
                                                 format:@"text"
                                                   from:[NSNumber numberWithInt:1]
                                                     to:[NSNumber numberWithInt:2]
                                              zipOutput:[NSNumber numberWithBool:NO]
                                                storage:nil
                                                 folder:nil
                                      completionHandler:^(ASPSplitDocumentResponse *output, NSError *error) {
                                          XCTAssertNotNil(output, @"Failed to split document");
                                          XCTAssertEqualObjects(output.status, @"OK");
                                          [expectation fulfill];
     }];
    
    [self waitForExpectationsWithTimeout:180.0 handler:^(NSError *error) {
        if (error) {
            NSLog(@"Timeout Error: %@", error);
        }
    }];
}

- (void)testGetDocumentStatistics {
    
    NSString *fileName = @"SampleWordDocument.docx";
    [self uploadFile:fileName];
    
    XCTestExpectation *expectation = [self expectationWithDescription:@""];
    
    [self.wordsApi getDocumentStatisticsWithCompletionBlock:fileName
                                            includeComments:[NSNumber numberWithBool:YES]
                                           includeFootnotes:[NSNumber numberWithBool:YES]
                                        includeTextInShapes:[NSNumber numberWithBool:YES]
                                                    storage:nil
                                                     folder:nil
                                          completionHandler:^(ASPStatDataResponse *output, NSError *error) {
                                              XCTAssertNotNil(output, @"Failed to read document statistics");
                                              XCTAssertEqualObjects(output.status, @"OK");
                                              [expectation fulfill];
                                          }];
    
    [self waitForExpectationsWithTimeout:180.0 handler:^(NSError *error) {
        if (error) {
            NSLog(@"Timeout Error: %@", error);
        }
    }];
}

- (void)testGetDocumentTextItems {
    
    NSString *fileName = @"SampleWordDocument.docx";
    [self uploadFile:fileName];
    
    XCTestExpectation *expectation = [self expectationWithDescription:@""];
    
    [self.wordsApi getDocumentTextItemsWithCompletionBlock:fileName
                                                   storage:nil
                                                    folder:nil
                                         completionHandler:^(ASPTextItemsResponse *output, NSError *error) {
                                             XCTAssertNotNil(output, @"Failed to read document text items");
                                             XCTAssertEqualObjects(output.status, @"OK");
                                             [expectation fulfill];
     }];
    
    [self waitForExpectationsWithTimeout:180.0 handler:^(NSError *error) {
        if (error) {
            NSLog(@"Timeout Error: %@", error);
        }
    }];
}

- (void)testPostUpdateDocumentFields {
    
    NSString *fileName = @"SampleWordDocument.docx";
    [self uploadFile:fileName];
    
    XCTestExpectation *expectation = [self expectationWithDescription:@""];
    
    [self.wordsApi postUpdateDocumentFieldsWithCompletionBlock:fileName
                                                      filename:nil
                                                       storage:nil
                                                        folder:nil
                                             completionHandler:^(ASPDocumentResponse *output, NSError *error) {
                                                 XCTAssertNotNil(output, @"Failed to update (reevaluate) fields in document");
                                                 XCTAssertEqualObjects(output.status, @"OK");
                                                 [expectation fulfill];
                                             }];
    
    [self waitForExpectationsWithTimeout:180.0 handler:^(NSError *error) {
        if (error) {
            NSLog(@"Timeout Error: %@", error);
        }
    }];
}

- (void)testDeleteDocumentWatermark {
    
    NSString *fileName = @"SampleWordDocument.docx";
    [self uploadFile:fileName];
    
    XCTestExpectation *expectation = [self expectationWithDescription:@""];
    
    [self.wordsApi deleteDocumentWatermarkWithCompletionBlock:fileName
                                                     filename:nil
                                                      storage:nil
                                                       folder:nil
                                            completionHandler:^(ASPDocumentResponse *output, NSError *error) {
                                                XCTAssertNotNil(output, @"Failed to delete watermark");
                                                XCTAssertEqualObjects(output.status, @"OK");
                                                [expectation fulfill];
                                            }];
    
    [self waitForExpectationsWithTimeout:180.0 handler:^(NSError *error) {
        if (error) {
            NSLog(@"Timeout Error: %@", error);
        }
    }];
}

- (void)testPostInsertDocumentWatermarkImage {
    
    NSString *fileName = @"SampleWordDocument.docx";
    [self uploadFile:fileName];
    
    XCTestExpectation *expectation = [self expectationWithDescription:@""];
    
    [self.wordsApi postInsertDocumentWatermarkImageWithCompletionBlock:fileName
                                                              filename:nil
                                                         rotationAngle:[NSNumber numberWithDouble:45]
                                                                 image:@"aspose-cloud.png"
                                                               storage:nil
                                                                folder:nil
                                                     completionHandler:^(ASPDocumentResponse *output, NSError *error) {
                                                         XCTAssertNotNil(output, @"Failed to insert document watermark image");
                                                         XCTAssertEqualObjects(output.status, @"OK");
                                                         [expectation fulfill];
                                                     }];
    
    [self waitForExpectationsWithTimeout:180.0 handler:^(NSError *error) {
        if (error) {
            NSLog(@"Timeout Error: %@", error);
        }
    }];
}

- (void)testPostInsertDocumentWatermarkText {
    
    NSString *fileName = @"SampleWordDocument.docx";
    [self uploadFile:fileName];
    
    XCTestExpectation *expectation = [self expectationWithDescription:@""];
    
    ASPWatermarkText *watermarkText = [[ASPWatermarkText alloc] init];
    watermarkText.text = @"Welcome Aspose";
    watermarkText.rotationAngle = [NSNumber numberWithDouble:45];
    
    [self.wordsApi postInsertDocumentWatermarkTextWithCompletionBlock:fileName
                                                        watermarkText:watermarkText
                                                             filename:nil
                                                                 text:nil
                                                        rotationAngle:nil
                                                              storage:nil
                                                               folder:nil
                                                    completionHandler:^(ASPDocumentResponse *output, NSError *error) {
                                                        XCTAssertNotNil(output, @"Failed to insert document watermark text");
                                                        XCTAssertEqualObjects(output.status, @"OK");
                                                        [expectation fulfill];
                                                    }];
    
    [self waitForExpectationsWithTimeout:180.0 handler:^(NSError *error) {
        if (error) {
            NSLog(@"Timeout Error: %@", error);
        }
    }];
}

@end