//
//  Protection.m
//  Aspose.Words
//
//  Created by Muhammad Sohail Ismail on 17/03/2017.
//  Copyright © 2017 Aspose. All rights reserved.
//

#import "Protection.h"
#import "Utils.h"
#import "ASPWordsApi.h"

@implementation Protection

- (id)init {
    self = [super init];
    
    self.wordsApi = [[ASPWordsApi alloc] init];
    
    return self;
}

- (void)deleteUnprotectDocument {
//ExStart:DeleteUnprotectDocument
    
    NSString *fileName = @"SampleWordDocument.docx";
    [Utils uploadFile:fileName];
    
    ASPProtectionRequest *protectionData = [[ASPProtectionRequest alloc] init];
    protectionData.password = @"123456";
    
    [self.wordsApi deleteUnprotectDocumentWithCompletionBlock:fileName
                                            protectionRequest:protectionData
                                                     filename:nil
                                                      storage:nil
                                                       folder:nil
                                            completionHandler:^(ASPProtectionDataResponse *output, NSError *error) {
                                                NSLog(@"%@", output);
                                            }];
//ExEnd:DeleteUnprotectDocument
}

- (void)getDocumentProtection {
//ExStart:GetDocumentProtection
    
    NSString *fileName = @"SampleWordDocument.docx";
    [Utils uploadFile:fileName];
    
    [self.wordsApi getDocumentProtectionWithCompletionBlock:fileName
                                                    storage:nil
                                                     folder:nil
                                          completionHandler:^(ASPProtectionDataResponse *output, NSError *error) {
                                              NSLog(@"%@", output);
                                          }];
//ExEnd:GetDocumentProtection
}

- (void)postChangeDocumentProtection {
//ExStart:PostChangeDocumentProtection
    
    NSString *fileName = @"SampleWordDocument.docx";
    [Utils uploadFile:fileName];
    
    ASPProtectionRequest *protectionData = [[ASPProtectionRequest alloc] init];
    protectionData.password = @"123456";
    protectionData.latestPassword = @"123456789";
    
    [self.wordsApi postChangeDocumentProtectionWithCompletionBlock:fileName
                                                 protectionRequest:protectionData
                                                          filename:nil
                                                           storage:nil
                                                            folder:nil
                                                 completionHandler:^(ASPProtectionDataResponse *output, NSError *error) {
                                                     NSLog(@"%@", output);
                                                 }];
//ExEnd:PostChangeDocumentProtection
}

- (void)putProtectDocument {
//ExStart:PutProtectDocument
    
    NSString *fileName = @"SampleWordDocument.docx";
    [Utils uploadFile:fileName];
    
    ASPProtectionRequest *protectionData = [[ASPProtectionRequest alloc] init];
    protectionData.password = @"123456";
    protectionData.protectionType = @"AllowOnlyComments";
    
    [self.wordsApi putProtectDocumentWithCompletionBlock:fileName
                                       protectionRequest:protectionData
                                                filename:nil
                                                 storage:nil
                                                  folder:nil
                                       completionHandler:^(ASPProtectionDataResponse *output, NSError *error) {
                                           NSLog(@"%@", output);
                                       }];
//ExEnd:PutProtectDocument
}


@end
