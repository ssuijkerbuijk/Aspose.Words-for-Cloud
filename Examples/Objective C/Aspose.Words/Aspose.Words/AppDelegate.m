//
//  AppDelegate.m
//  Aspose.Words
//
//  Created by Muhammad Sohail Ismail on 16/03/2017.
//  Copyright © 2017 Aspose. All rights reserved.
//

#import "AppDelegate.h"
#import "Utils.h"
#import "Bookmarks.h"
#import "DocumentProperties.h"
#import "Document.h"
#import "DrawingObjects.h"
#import "Fields.h"
#import "HeadersAndFooters.h"
#import "Hyperlinks.h"
#import "MailMerge.h"
#import "Paragraphs.h"
#import "Protection.h"
#import "Sections.h"
#import "SplitResource.h"
#import "Text.h"
#import "Watermark.h"

@interface AppDelegate ()

@end

@implementation AppDelegate


- (BOOL)application:(UIApplication *)application didFinishLaunchingWithOptions:(NSDictionary *)launchOptions {
    
    //Get App key and App SID from https://cloud.aspose.com
    [Utils setAppKeyAndAppSID];
    
    Bookmarks *bookmarks = [[Bookmarks alloc] init];
    [bookmarks getDocumentBookmarkByName];
    [bookmarks getDocumentBookmarks];
    [bookmarks postUpdateDocumentBookmark];
    
    DocumentProperties *documentProperties = [[DocumentProperties alloc] init];
    [documentProperties deleteDocumentProperty];
    [documentProperties getDocumentProperties];
    [documentProperties getDocumentProperty];
    [documentProperties putUpdateDocumentProperty];
    
    Document *document = [[Document alloc] init];
    [document testAcceptAllRevisions];
    [document deleteDocumentMacros];
    [document getDocument];
    [document getDocumentStatistics];
    [document getDocumentWithFormat];
    [document postAppendDocument];
    [document postDocumentSaveAs];
    [document postLoadWebDocument];
    [document postRunTask];
    [document putConvertDocument];
    [document putDocumentSaveAsTiff];
    [document testRejectAllRevisions];
    
    DrawingObjects *drawingObjects = [[DrawingObjects alloc] init];
    [drawingObjects getDocumentDrawingObjectByIndex];
    [drawingObjects getDocumentDrawingObjectByIndexWithFormat];
    [drawingObjects getDocumentDrawingObjectImageData];
    [drawingObjects getDocumentDrawingObjectOleData];
    [drawingObjects getDocumentDrawingObjects];
    
    Fields *fields = [[Fields alloc] init];
    [fields deleteDocumentFields];
    [fields deleteFormField];
    [fields deleteSectionFields];
    [fields getFormField];
    [fields postFormField];
    [fields postInsertPageNumbers];
    [fields postUpdateDocumentFields];
    [fields putFormField];
    [fields getDocumentFieldNames];
    
    HeadersAndFooters *headersAndFooters = [[HeadersAndFooters alloc] init];
    [headersAndFooters deleteHeadersFooters];

    Hyperlinks *hyperlinks = [[Hyperlinks alloc] init];
    [hyperlinks getDocumentHyperlinkByIndex];
    [hyperlinks getDocumentHyperlinks];
    
    MailMerge *mailMerge = [[MailMerge alloc] init];
    [mailMerge postExecuteTemplate];
    [mailMerge postDocumentExecuteMailMerge];
    [mailMerge putExecuteMailMergeOnline];
    [mailMerge putExecuteTemplateOnline];
    
    Paragraphs *paragraphs = [[Paragraphs alloc] init];
    [paragraphs deleteParagraphFields];
    [paragraphs getDocumentParagraph];
    [paragraphs getDocumentParagraphRun];
    [paragraphs getDocumentParagraphRunFont];
    [paragraphs getDocumentParagraphs];
    [paragraphs postDocumentParagraphRunFont];
    
    Protection *protection = [[Protection alloc] init];
    [protection deleteUnprotectDocument];
    [protection getDocumentProtection];
    [protection postChangeDocumentProtection];
    [protection putProtectDocument];
    
    Sections *sections = [[Sections alloc] init];
    [sections getSection];
    [sections getSectionPageSetup];
    [sections getSections];
    [sections testUpdateSectionPageSetup];
    
    SplitResource *splitResource = [[SplitResource alloc] init];
    [splitResource splitAllPagesToNewPdfs];
    [splitResource splitSpecificPagesToAnySupportedFormat];
    [splitResource splitSpecificPagesToNewPdfs];
    
    Text *text = [[Text alloc] init];
    [text getDocumentTextItems];
    [text postReplaceText];
    
    Watermark *watermark = [[Watermark alloc] init];
    [watermark deleteDocumentWatermark];
    [watermark postInsertDocumentWatermarkImage];
    [watermark postInsertDocumentWatermarkText];

    return YES;
}


- (void)applicationWillResignActive:(UIApplication *)application {
    // Sent when the application is about to move from active to inactive state. This can occur for certain types of temporary interruptions (such as an incoming phone call or SMS message) or when the user quits the application and it begins the transition to the background state.
    // Use this method to pause ongoing tasks, disable timers, and invalidate graphics rendering callbacks. Games should use this method to pause the game.
}


- (void)applicationDidEnterBackground:(UIApplication *)application {
    // Use this method to release shared resources, save user data, invalidate timers, and store enough application state information to restore your application to its current state in case it is terminated later.
    // If your application supports background execution, this method is called instead of applicationWillTerminate: when the user quits.
}


- (void)applicationWillEnterForeground:(UIApplication *)application {
    // Called as part of the transition from the background to the active state; here you can undo many of the changes made on entering the background.
}


- (void)applicationDidBecomeActive:(UIApplication *)application {
    // Restart any tasks that were paused (or not yet started) while the application was inactive. If the application was previously in the background, optionally refresh the user interface.
}


- (void)applicationWillTerminate:(UIApplication *)application {
    // Called when the application is about to terminate. Save data if appropriate. See also applicationDidEnterBackground:.
}


@end
