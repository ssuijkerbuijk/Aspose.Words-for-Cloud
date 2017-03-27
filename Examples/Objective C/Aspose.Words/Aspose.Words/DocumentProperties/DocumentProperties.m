//
//  DocumentProperties.m
//  Aspose.Words
//
//  Created by Muhammad Sohail Ismail on 16/03/2017.
//  Copyright © 2017 Aspose. All rights reserved.
//

#import "DocumentProperties.h"
#import "Utils.h"
#import "ASPWordsApi.h"

@implementation DocumentProperties

- (id)init {
    self = [super init];
    
    self.wordsApi = [[ASPWordsApi alloc] init];
    
    return self;
}

- (void)deleteDocumentProperty {
//ExStart:DeleteDocumentProperty
    
    NSString *fileName = @"SampleWordDocument.docx";
    [Utils uploadFile:fileName];
    
    [self.wordsApi deleteDocumentPropertyWithCompletionBlock:fileName
                                                propertyName:@"AsposeAuthor"
                                                    filename:nil
                                                     storage:nil
                                                      folder:nil
                                           completionHandler:^(ASPBaseResponse *output, NSError *error) {
                                               NSLog(@"%@", output);
                                           }];
//ExEnd:DeleteDocumentProperty
}

- (void)getDocumentProperties {
//ExStart:GetDocumentProperties
    
    NSString *fileName = @"SampleWordDocument.docx";
    [Utils uploadFile:fileName];
    
    [self.wordsApi getDocumentPropertiesWithCompletionBlock:fileName
                                                    storage:nil
                                                     folder:nil
                                          completionHandler:^(ASPDocumentPropertiesResponse *output, NSError *error) {
                                              NSLog(@"%@", output);
                                          }];
//ExEnd:GetDocumentProperties
}

- (void)getDocumentProperty {
//ExStart:GetDocumentProperty
    
    NSString *fileName = @"SampleWordDocument.docx";
    [Utils uploadFile:fileName];
    
    [self.wordsApi getDocumentPropertyWithCompletionBlock:fileName
                                             propertyName:@"Author"
                                                  storage:nil
                                                   folder:nil
                                        completionHandler:^(ASPDocumentPropertyResponse *output, NSError *error) {
                                            NSLog(@"%@", output);
                                        }];
//ExEnd:GetDocumentProperty
}

- (void)putUpdateDocumentProperty {
//ExStart:PutUpdateDocumentProperty
    
    NSString *fileName = @"SampleWordDocument.docx";
    [Utils uploadFile:fileName];
    
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
                                                  NSLog(@"%@", output);
                                              }];
//ExEnd:PutUpdateDocumentProperty
}

@end
