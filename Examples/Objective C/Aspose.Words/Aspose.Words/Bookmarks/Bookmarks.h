//
//  Bookmarks.h
//  Aspose.Words
//
//  Created by Muhammad Sohail Ismail on 16/03/2017.
//  Copyright © 2017 Aspose. All rights reserved.
//

#import <Foundation/Foundation.h>
@class ASPWordsApi;

@interface Bookmarks : NSObject

@property(nonatomic, strong) ASPWordsApi *wordsApi;

- (void)getDocumentBookmarkByName;
- (void)getDocumentBookmarks;
- (void)postUpdateDocumentBookmark;

@end
