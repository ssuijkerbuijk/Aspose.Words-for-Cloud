//
//  Sections.m
//  Aspose.Words
//
//  Created by Muhammad Sohail Ismail on 17/03/2017.
//  Copyright © 2017 Aspose. All rights reserved.
//

#import "Sections.h"
#import "Utils.h"
#import "ASPWordsApi.h"

@implementation Sections

- (id)init {
    self = [super init];
    
    self.wordsApi = [[ASPWordsApi alloc] init];
    
    return self;
}

- (void)getSection {
//ExStart:GetSection
    
    NSString *fileName = @"SampleWordDocument.docx";
    [Utils uploadFile:fileName];
    
    [self.wordsApi getSectionWithCompletionBlock:fileName
                                    sectionIndex:[NSNumber numberWithInt:0]
                                         storage:nil
                                          folder:nil
                               completionHandler:^(ASPSectionResponse *output, NSError *error) {
                                   NSLog(@"%@", output);
                               }];
//ExEnd:GetSection
}

- (void)getSectionPageSetup {
//ExStart:GetSectionPageSetup
    
    NSString *fileName = @"SampleWordDocument.docx";
    [Utils uploadFile:fileName];
    
    [self.wordsApi getSectionPageSetupWithCompletionBlock:fileName
                                             sectionIndex:[NSNumber numberWithInt:0]
                                                  storage:nil
                                                   folder:nil
                                        completionHandler:^(ASPSectionPageSetupResponse *output, NSError *error) {
                                            NSLog(@"%@", output);
                                        }];
//ExEnd:GetSectionPageSetup
}

- (void)getSections {
//ExStart:GetSections
    
    NSString *fileName = @"SampleWordDocument.docx";
    [Utils uploadFile:fileName];
    
    [self.wordsApi getSectionsWithCompletionBlock:fileName
                                          storage:nil
                                           folder:nil
                                completionHandler:^(ASPSectionLinkCollectionResponse *output, NSError *error) {
                                    NSLog(@"%@", output);
                                }];
//ExEnd:GetSections
}

- (void)testUpdateSectionPageSetup {
//ExStart:TestUpdateSectionPageSetup
    
    NSString *fileName = @"SampleWordDocument.docx";
    [Utils uploadFile:fileName];
    
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
                                               NSLog(@"%@", output);
                                           }];
//ExEnd:TestUpdateSectionPageSetup
}

@end
