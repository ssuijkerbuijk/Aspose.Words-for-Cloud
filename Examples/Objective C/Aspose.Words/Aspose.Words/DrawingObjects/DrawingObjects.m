//
//  DrawingObjects.m
//  Aspose.Words
//
//  Created by Muhammad Sohail Ismail on 16/03/2017.
//  Copyright © 2017 Aspose. All rights reserved.
//

#import "DrawingObjects.h"
#import "Utils.h"
#import "ASPWordsApi.h"

@implementation DrawingObjects

- (id)init {
    self = [super init];
    
    self.wordsApi = [[ASPWordsApi alloc] init];
    
    return self;
}

- (void)getDocumentDrawingObjectByIndex {
    
    NSString *fileName = @"OLE.docx";
    [Utils uploadFile:fileName];
    
    [self.wordsApi getDocumentDrawingObjectByIndexWithCompletionBlock:fileName
                                                          objectIndex:[NSNumber numberWithInt:0]
                                                              storage:nil
                                                               folder:nil
                                                    completionHandler:^(ASPDrawingObjectResponse *output, NSError *error) {
                                                        NSLog(@"%@", output);
                                                    }];
}

- (void)getDocumentDrawingObjectByIndexWithFormat {
    
    NSString *fileName = @"OLE.docx";
    [Utils uploadFile:fileName];
    
    [self.wordsApi getDocumentDrawingObjectByIndexWithFormatWithCompletionBlock:fileName
                                                                    objectIndex:[NSNumber numberWithInt:0]
                                                                         format:@"png"
                                                                        storage:nil
                                                                         folder:nil
                                                              completionHandler:^(NSURL *output, NSError *error) {
                                                                  NSLog(@"%@", output);
                                                              }];
}

- (void)getDocumentDrawingObjectImageData {
    
    NSString *fileName = @"SampleWordDocument.docx";
    [Utils uploadFile:fileName];
    
    [self.wordsApi getDocumentDrawingObjectImageDataWithCompletionBlock:fileName
                                                            objectIndex:[NSNumber numberWithInt:2]
                                                                storage:nil
                                                                 folder:nil
                                                      completionHandler:^(NSURL *output, NSError *error) {
                                                          NSLog(@"%@", output);
                                                      }];
}

- (void)getDocumentDrawingObjectOleData {
    
    NSString *fileName = @"Sample_EmbeddedOLE.docx";
    [Utils uploadFile:fileName];
    
    [self.wordsApi getDocumentDrawingObjectOleDataWithCompletionBlock:fileName
                                                          objectIndex:[NSNumber numberWithInt:0]
                                                              storage:nil
                                                               folder:nil
                                                    completionHandler:^(NSURL *output, NSError *error) {
                                                        NSLog(@"%@", output);
                                                    }];
}

- (void)getDocumentDrawingObjects {
    
    NSString *fileName = @"SampleWordDocument.docx";
    [Utils uploadFile:fileName];
    
    [self.wordsApi getDocumentDrawingObjectsWithCompletionBlock:fileName
                                                        storage:nil
                                                         folder:nil
                                              completionHandler:^(ASPDrawingObjectsResponse *output, NSError *error) {
                                                  NSLog(@"%@", output);
                                              }];
}


@end
