//
//  Bookmarks.m
//  Aspose.Words
//
//  Created by Muhammad Sohail Ismail on 16/03/2017.
//  Copyright © 2017 Aspose. All rights reserved.
//

#import "Bookmarks.h"
#import "Utils.h"
#import "ASPWordsApi.h"

@implementation Bookmarks

- (id)init {
    self = [super init];
    
    self.wordsApi = [[ASPWordsApi alloc] init];
    
    return self;
}

- (void)getDocumentBookmarkByName {
    
    NSString *fileName = @"SampleWordDocument.docx";
    [Utils uploadFile:fileName];
    
    [self.wordsApi getDocumentBookmarkByNameWithCompletionBlock:fileName
                                                   bookmarkName:@"aspose"
                                                        storage:nil
                                                         folder:nil
                                              completionHandler:^(ASPBookmarkResponse *output, NSError *error) {
                                                  NSLog(@"%@", output);
                                              }];
}

- (void)getDocumentBookmarks {
    
    NSString *fileName = @"SampleWordDocument.docx";
    [Utils uploadFile:fileName];
    
    [self.wordsApi getDocumentBookmarksWithCompletionBlock:fileName
                                                   storage:nil
                                                    folder:nil
                                         completionHandler:^(ASPBookmarksResponse *output, NSError *error) {
                                             NSLog(@"%@", output);
                                         }];
}

- (void)postUpdateDocumentBookmark {
    
    NSString *fileName = @"SampleWordDocument.docx";
    [Utils uploadFile:fileName];
    
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
                                                   NSLog(@"%@", output);
                                               }];
}


@end
