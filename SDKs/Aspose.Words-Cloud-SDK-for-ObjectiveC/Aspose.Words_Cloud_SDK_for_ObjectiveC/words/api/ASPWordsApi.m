#import "ASPWordsApi.h"
#import "ASPQueryParamCollection.h"
#import "ASPSaveResponse.h"
#import "ASPLoadWebDocumentData.h"
#import "ASPFieldNamesResponse.h"
#import "ASPResponseMessage.h"
#import "ASPSaveOptionsData.h"
#import "ASPTiffSaveOptionsData.h"
#import "ASPDocumentResponse.h"
#import "ASPDocumentEntryList.h"
#import "ASPBookmarksResponse.h"
#import "ASPBookmarkResponse.h"
#import "ASPBookmarkData.h"
#import "ASPCommentsResponse.h"
#import "ASPCommentResponse.h"
#import "ASPComment.h"
#import "ASPBaseResponse.h"
#import "ASPDocumentPropertiesResponse.h"
#import "ASPDocumentPropertyResponse.h"
#import "ASPDocumentProperty.h"
#import "ASPDrawingObjectsResponse.h"
#import "ASPHyperlinksResponse.h"
#import "ASPHyperlinkResponse.h"
#import "ASPPageNumber.h"
#import "ASPWatermarkText.h"
#import "ASPParagraphLinkCollectionResponse.h"
#import "ASPParagraphResponse.h"
#import "ASPRunResponse.h"
#import "ASPFontResponse.h"
#import "ASPFont.h"
#import "ASPProtectionDataResponse.h"
#import "ASPProtectionRequest.h"
#import "ASPReplaceTextRequest.h"
#import "ASPReplaceTextResponse.h"
#import "ASPRevisionsModificationResponse.h"
#import "ASPSearchResponse.h"
#import "ASPSectionLinkCollectionResponse.h"
#import "ASPSectionResponse.h"
#import "ASPSectionPageSetupResponse.h"
#import "ASPPageSetup.h"
#import "ASPField.h"
#import "ASPFieldResponse.h"
#import "ASPFormField.h"
#import "ASPFormFieldResponse.h"
#import "ASPSplitDocumentResponse.h"
#import "ASPStatDataResponse.h"
#import "ASPTextItemsResponse.h"


@interface ASPWordsApi ()
    @property (readwrite, nonatomic, strong) NSMutableDictionary *defaultHeaders;
@end

@implementation ASPWordsApi

#pragma mark - Initialize methods

- (id) init {
    self = [super init];
    if (self) {
        ASPConfiguration *config = [ASPConfiguration sharedConfig];
        if (config.apiClient == nil) {
            config.apiClient = [[ASPApiClient alloc] init];
        }
        self.apiClient = config.apiClient;
        self.defaultHeaders = [NSMutableDictionary dictionary];
    }
    return self;
}

- (id) initWithApiClient:(ASPApiClient *)apiClient {
    self = [super init];
    if (self) {
        self.apiClient = apiClient;
        self.defaultHeaders = [NSMutableDictionary dictionary];
    }
    return self;
}

#pragma mark -

+(ASPWordsApi*) apiWithHeader:(NSString*)headerValue key:(NSString*)key {
    static ASPWordsApi* singletonAPI = nil;

    if (singletonAPI == nil) {
        singletonAPI = [[ASPWordsApi alloc] init];
        [singletonAPI addHeader:headerValue forKey:key];
    }
    return singletonAPI;
}

-(void) addHeader:(NSString*)value forKey:(NSString*)key {
    [self.defaultHeaders setValue:value forKey:key];
}

-(void) setHeaderValue:(NSString*) value
           forKey:(NSString*)key {
    [self.defaultHeaders setValue:value forKey:key];
}

-(unsigned long) requestQueueSize {
    return [ASPApiClient requestQueueSize];
}

#pragma mark - Api Methods

///
/// Convert document from request content to format specified.
/// 
///  @param file 
///
///  @param format Format to convert.
///
///  @param outPath Path for saving operation result to the local storage.
///
///  @param replaceResourcesHostTo Controls wherefrom Aspose.Words loads external resource when importing a document from HTML or MHTML.
///
///  @returns NSURL*
///
-(NSNumber*) putConvertDocumentWithCompletionBlock: (NSURL*) file
         format: (NSString*) format
         outPath: (NSString*) outPath
         replaceResourcesHostTo: (NSString*) replaceResourcesHostTo
        
        completionHandler: (void (^)(NSURL* output, NSError* error))completionBlock { 
        

    
    // verify the required parameter 'file' is set
    if (file == nil) {
        [NSException raise:@"Invalid parameter" format:@"Missing the required parameter `file` when calling `putConvertDocument`"];
    }
    

    NSMutableString* resourcePath = [NSMutableString stringWithFormat:@"/words/convert"];

    // remove format in URL if needed
    if ([resourcePath rangeOfString:@".{format}"].location != NSNotFound) {
        [resourcePath replaceCharactersInRange: [resourcePath rangeOfString:@".{format}"] withString:@".json"];
    }

    NSMutableDictionary *pathParams = [[NSMutableDictionary alloc] init];
    

    NSMutableDictionary* queryParams = [[NSMutableDictionary alloc] init];
    if(format != nil) {
        
        queryParams[@"format"] = format;
    }
    if(outPath != nil) {
        
        queryParams[@"outPath"] = outPath;
    }
    if(replaceResourcesHostTo != nil) {
        
        queryParams[@"replaceResourcesHostTo"] = replaceResourcesHostTo;
    }
    
    NSMutableDictionary* headerParams = [NSMutableDictionary dictionaryWithDictionary:self.defaultHeaders];

    

    // HTTP header `Accept`
    headerParams[@"Accept"] = [ASPApiClient selectHeaderAccept:@[]];
    if ([headerParams[@"Accept"] length] == 0) {
        [headerParams removeObjectForKey:@"Accept"];
    }

    // response content type
    NSString *responseContentType;
    if ([headerParams objectForKey:@"Accept"]) {
        responseContentType = [headerParams[@"Accept"] componentsSeparatedByString:@", "][0];
    }
    else {
        responseContentType = @"";
    }

    // request content type
    NSString *requestContentType = [ASPApiClient selectHeaderContentType:@[@"multipart/form-data"]];

    // Authentication setting
    NSArray *authSettings = @[];

    id bodyParam = nil;
    NSMutableDictionary *formParams = [[NSMutableDictionary alloc] init];
    NSMutableDictionary *files = [[NSMutableDictionary alloc] init];
    
    
    
    files[@"file"] = file;
    
    
    

    
    return [self.apiClient requestWithCompletionBlock: resourcePath
                                               method: @"PUT"
                                           pathParams: pathParams
                                          queryParams: queryParams
                                           formParams: formParams
                                                files: files
                                                 body: bodyParam
                                         headerParams: headerParams
                                         authSettings: authSettings
                                   requestContentType: requestContentType
                                  responseContentType: responseContentType
                                         responseType: @"NSURL*"
                                      completionBlock: ^(id data, NSError *error) {
                  
                  completionBlock((NSURL*)data, error);
              }
          ];
}

///
/// Execute document mail merge online.
/// 
///  @param withRegions With regions flag.
///
///  @param file 
///
///  @param data 
///
///  @param cleanup Clean up options.
///
///  @returns NSURL*
///
-(NSNumber*) putExecuteMailMergeOnlineWithCompletionBlock: (NSNumber*) withRegions
         file: (NSURL*) file
         data: (NSURL*) data
         cleanup: (NSString*) cleanup
        
        completionHandler: (void (^)(NSURL* output, NSError* error))completionBlock { 
        

    
    // verify the required parameter 'withRegions' is set
    if (withRegions == nil) {
        [NSException raise:@"Invalid parameter" format:@"Missing the required parameter `withRegions` when calling `putExecuteMailMergeOnline`"];
    }
    
    // verify the required parameter 'file' is set
    if (file == nil) {
        [NSException raise:@"Invalid parameter" format:@"Missing the required parameter `file` when calling `putExecuteMailMergeOnline`"];
    }
    
    // verify the required parameter 'data' is set
    if (data == nil) {
        [NSException raise:@"Invalid parameter" format:@"Missing the required parameter `data` when calling `putExecuteMailMergeOnline`"];
    }
    

    NSMutableString* resourcePath = [NSMutableString stringWithFormat:@"/words/executeMailMerge"];

    // remove format in URL if needed
    if ([resourcePath rangeOfString:@".{format}"].location != NSNotFound) {
        [resourcePath replaceCharactersInRange: [resourcePath rangeOfString:@".{format}"] withString:@".json"];
    }

    NSMutableDictionary *pathParams = [[NSMutableDictionary alloc] init];
    

    NSMutableDictionary* queryParams = [[NSMutableDictionary alloc] init];
    if(withRegions != nil) {
        
        queryParams[@"withRegions"] = withRegions;
    }
    if(cleanup != nil) {
        
        queryParams[@"cleanup"] = cleanup;
    }
    
    NSMutableDictionary* headerParams = [NSMutableDictionary dictionaryWithDictionary:self.defaultHeaders];

    

    // HTTP header `Accept`
    headerParams[@"Accept"] = [ASPApiClient selectHeaderAccept:@[]];
    if ([headerParams[@"Accept"] length] == 0) {
        [headerParams removeObjectForKey:@"Accept"];
    }

    // response content type
    NSString *responseContentType;
    if ([headerParams objectForKey:@"Accept"]) {
        responseContentType = [headerParams[@"Accept"] componentsSeparatedByString:@", "][0];
    }
    else {
        responseContentType = @"";
    }

    // request content type
    NSString *requestContentType = [ASPApiClient selectHeaderContentType:@[@"multipart/form-data"]];

    // Authentication setting
    NSArray *authSettings = @[];

    id bodyParam = nil;
    NSMutableDictionary *formParams = [[NSMutableDictionary alloc] init];
    NSMutableDictionary *files = [[NSMutableDictionary alloc] init];
    
    
    
    files[@"file"] = file;
    
    
    
    files[@"data"] = data;
    
    
    

    
    return [self.apiClient requestWithCompletionBlock: resourcePath
                                               method: @"PUT"
                                           pathParams: pathParams
                                          queryParams: queryParams
                                           formParams: formParams
                                                files: files
                                                 body: bodyParam
                                         headerParams: headerParams
                                         authSettings: authSettings
                                   requestContentType: requestContentType
                                  responseContentType: responseContentType
                                         responseType: @"NSURL*"
                                      completionBlock: ^(id data, NSError *error) {
                  
                  completionBlock((NSURL*)data, error);
              }
          ];
}

///
/// Populate document template with data online.
/// 
///  @param file 
///
///  @param data 
///
///  @param cleanup Clean up options.
///
///  @param useWholeParagraphAsRegion Gets or sets a value indicating whether paragraph with TableStart or TableEnd field should be fully included into mail merge region or particular range between TableStart and TableEnd fields. The default value is true.
///
///  @param withRegions Merge with regions or not. True by default
///
///  @returns NSURL*
///
-(NSNumber*) putExecuteTemplateOnlineWithCompletionBlock: (NSURL*) file
         data: (NSURL*) data
         cleanup: (NSString*) cleanup
         useWholeParagraphAsRegion: (NSNumber*) useWholeParagraphAsRegion
         withRegions: (NSNumber*) withRegions
        
        completionHandler: (void (^)(NSURL* output, NSError* error))completionBlock { 
        

    
    // verify the required parameter 'file' is set
    if (file == nil) {
        [NSException raise:@"Invalid parameter" format:@"Missing the required parameter `file` when calling `putExecuteTemplateOnline`"];
    }
    
    // verify the required parameter 'data' is set
    if (data == nil) {
        [NSException raise:@"Invalid parameter" format:@"Missing the required parameter `data` when calling `putExecuteTemplateOnline`"];
    }
    

    NSMutableString* resourcePath = [NSMutableString stringWithFormat:@"/words/executeTemplate"];

    // remove format in URL if needed
    if ([resourcePath rangeOfString:@".{format}"].location != NSNotFound) {
        [resourcePath replaceCharactersInRange: [resourcePath rangeOfString:@".{format}"] withString:@".json"];
    }

    NSMutableDictionary *pathParams = [[NSMutableDictionary alloc] init];
    

    NSMutableDictionary* queryParams = [[NSMutableDictionary alloc] init];
    if(cleanup != nil) {
        
        queryParams[@"cleanup"] = cleanup;
    }
    if(useWholeParagraphAsRegion != nil) {
        
        queryParams[@"useWholeParagraphAsRegion"] = useWholeParagraphAsRegion;
    }
    if(withRegions != nil) {
        
        queryParams[@"withRegions"] = withRegions;
    }
    
    NSMutableDictionary* headerParams = [NSMutableDictionary dictionaryWithDictionary:self.defaultHeaders];

    

    // HTTP header `Accept`
    headerParams[@"Accept"] = [ASPApiClient selectHeaderAccept:@[]];
    if ([headerParams[@"Accept"] length] == 0) {
        [headerParams removeObjectForKey:@"Accept"];
    }

    // response content type
    NSString *responseContentType;
    if ([headerParams objectForKey:@"Accept"]) {
        responseContentType = [headerParams[@"Accept"] componentsSeparatedByString:@", "][0];
    }
    else {
        responseContentType = @"";
    }

    // request content type
    NSString *requestContentType = [ASPApiClient selectHeaderContentType:@[@"multipart/form-data"]];

    // Authentication setting
    NSArray *authSettings = @[];

    id bodyParam = nil;
    NSMutableDictionary *formParams = [[NSMutableDictionary alloc] init];
    NSMutableDictionary *files = [[NSMutableDictionary alloc] init];
    
    
    
    files[@"file"] = file;
    
    
    
    files[@"data"] = data;
    
    
    

    
    return [self.apiClient requestWithCompletionBlock: resourcePath
                                               method: @"PUT"
                                           pathParams: pathParams
                                          queryParams: queryParams
                                           formParams: formParams
                                                files: files
                                                 body: bodyParam
                                         headerParams: headerParams
                                         authSettings: authSettings
                                   requestContentType: requestContentType
                                  responseContentType: responseContentType
                                         responseType: @"NSURL*"
                                      completionBlock: ^(id data, NSError *error) {
                  
                  completionBlock((NSURL*)data, error);
              }
          ];
}

///
/// Load new document from web into the file with any supported format of data.
/// 
///  @param data 
///
///  @returns ASPSaveResponse*
///
-(NSNumber*) postLoadWebDocumentWithCompletionBlock: (ASPLoadWebDocumentData*) data
        
        completionHandler: (void (^)(ASPSaveResponse* output, NSError* error))completionBlock { 
        

    
    // verify the required parameter 'data' is set
    if (data == nil) {
        [NSException raise:@"Invalid parameter" format:@"Missing the required parameter `data` when calling `postLoadWebDocument`"];
    }
    

    NSMutableString* resourcePath = [NSMutableString stringWithFormat:@"/words/loadWebDocument"];

    // remove format in URL if needed
    if ([resourcePath rangeOfString:@".{format}"].location != NSNotFound) {
        [resourcePath replaceCharactersInRange: [resourcePath rangeOfString:@".{format}"] withString:@".json"];
    }

    NSMutableDictionary *pathParams = [[NSMutableDictionary alloc] init];
    

    NSMutableDictionary* queryParams = [[NSMutableDictionary alloc] init];
    
    NSMutableDictionary* headerParams = [NSMutableDictionary dictionaryWithDictionary:self.defaultHeaders];

    

    // HTTP header `Accept`
    headerParams[@"Accept"] = [ASPApiClient selectHeaderAccept:@[@"application/json"]];
    if ([headerParams[@"Accept"] length] == 0) {
        [headerParams removeObjectForKey:@"Accept"];
    }

    // response content type
    NSString *responseContentType;
    if ([headerParams objectForKey:@"Accept"]) {
        responseContentType = [headerParams[@"Accept"] componentsSeparatedByString:@", "][0];
    }
    else {
        responseContentType = @"";
    }

    // request content type
    NSString *requestContentType = [ASPApiClient selectHeaderContentType:@[@"application/json"]];

    // Authentication setting
    NSArray *authSettings = @[];

    id bodyParam = nil;
    NSMutableDictionary *formParams = [[NSMutableDictionary alloc] init];
    NSMutableDictionary *files = [[NSMutableDictionary alloc] init];
    
    bodyParam = data;
    

    
    return [self.apiClient requestWithCompletionBlock: resourcePath
                                               method: @"POST"
                                           pathParams: pathParams
                                          queryParams: queryParams
                                           formParams: formParams
                                                files: files
                                                 body: bodyParam
                                         headerParams: headerParams
                                         authSettings: authSettings
                                   requestContentType: requestContentType
                                  responseContentType: responseContentType
                                         responseType: @"ASPSaveResponse*"
                                      completionBlock: ^(id data, NSError *error) {
                  
                  completionBlock((ASPSaveResponse*)data, error);
              }
          ];
}

///
/// Read document field names.
/// 
///  @param useNonMergeFields 
///
///  @returns ASPFieldNamesResponse*
///
-(NSNumber*) putDocumentFieldNamesWithCompletionBlock: (NSNumber*) useNonMergeFields
        
        completionHandler: (void (^)(ASPFieldNamesResponse* output, NSError* error))completionBlock { 
        

    

    NSMutableString* resourcePath = [NSMutableString stringWithFormat:@"/words/mailMergeFieldNames"];

    // remove format in URL if needed
    if ([resourcePath rangeOfString:@".{format}"].location != NSNotFound) {
        [resourcePath replaceCharactersInRange: [resourcePath rangeOfString:@".{format}"] withString:@".json"];
    }

    NSMutableDictionary *pathParams = [[NSMutableDictionary alloc] init];
    

    NSMutableDictionary* queryParams = [[NSMutableDictionary alloc] init];
    if(useNonMergeFields != nil) {
        
        queryParams[@"useNonMergeFields"] = useNonMergeFields;
    }
    
    NSMutableDictionary* headerParams = [NSMutableDictionary dictionaryWithDictionary:self.defaultHeaders];

    

    // HTTP header `Accept`
    headerParams[@"Accept"] = [ASPApiClient selectHeaderAccept:@[@"application/json"]];
    if ([headerParams[@"Accept"] length] == 0) {
        [headerParams removeObjectForKey:@"Accept"];
    }

    // response content type
    NSString *responseContentType;
    if ([headerParams objectForKey:@"Accept"]) {
        responseContentType = [headerParams[@"Accept"] componentsSeparatedByString:@", "][0];
    }
    else {
        responseContentType = @"";
    }

    // request content type
    NSString *requestContentType = [ASPApiClient selectHeaderContentType:@[@"application/json"]];

    // Authentication setting
    NSArray *authSettings = @[];

    id bodyParam = nil;
    NSMutableDictionary *formParams = [[NSMutableDictionary alloc] init];
    NSMutableDictionary *files = [[NSMutableDictionary alloc] init];
    
    
    

    
    return [self.apiClient requestWithCompletionBlock: resourcePath
                                               method: @"PUT"
                                           pathParams: pathParams
                                          queryParams: queryParams
                                           formParams: formParams
                                                files: files
                                                 body: bodyParam
                                         headerParams: headerParams
                                         authSettings: authSettings
                                   requestContentType: requestContentType
                                  responseContentType: responseContentType
                                         responseType: @"ASPFieldNamesResponse*"
                                      completionBlock: ^(id data, NSError *error) {
                  
                  completionBlock((ASPFieldNamesResponse*)data, error);
              }
          ];
}

///
/// Run tasks
/// 
///  @param file 
///
///  @returns ASPResponseMessage*
///
-(NSNumber*) postRunTaskWithCompletionBlock: (NSURL*) file
        
        completionHandler: (void (^)(ASPResponseMessage* output, NSError* error))completionBlock { 
        

    
    // verify the required parameter 'file' is set
    if (file == nil) {
        [NSException raise:@"Invalid parameter" format:@"Missing the required parameter `file` when calling `postRunTask`"];
    }
    

    NSMutableString* resourcePath = [NSMutableString stringWithFormat:@"/words/tasks"];

    // remove format in URL if needed
    if ([resourcePath rangeOfString:@".{format}"].location != NSNotFound) {
        [resourcePath replaceCharactersInRange: [resourcePath rangeOfString:@".{format}"] withString:@".json"];
    }

    NSMutableDictionary *pathParams = [[NSMutableDictionary alloc] init];
    

    NSMutableDictionary* queryParams = [[NSMutableDictionary alloc] init];
    
    NSMutableDictionary* headerParams = [NSMutableDictionary dictionaryWithDictionary:self.defaultHeaders];

    

    // HTTP header `Accept`
    headerParams[@"Accept"] = [ASPApiClient selectHeaderAccept:@[@"application/json"]];
    if ([headerParams[@"Accept"] length] == 0) {
        [headerParams removeObjectForKey:@"Accept"];
    }

    // response content type
    NSString *responseContentType;
    if ([headerParams objectForKey:@"Accept"]) {
        responseContentType = [headerParams[@"Accept"] componentsSeparatedByString:@", "][0];
    }
    else {
        responseContentType = @"";
    }

    // request content type
    NSString *requestContentType = [ASPApiClient selectHeaderContentType:@[@"multipart/form-data"]];

    // Authentication setting
    NSArray *authSettings = @[];

    id bodyParam = nil;
    NSMutableDictionary *formParams = [[NSMutableDictionary alloc] init];
    NSMutableDictionary *files = [[NSMutableDictionary alloc] init];
    
    
    
    files[@"file"] = file;
    
    
    

    
    return [self.apiClient requestWithCompletionBlock: resourcePath
                                               method: @"POST"
                                           pathParams: pathParams
                                          queryParams: queryParams
                                           formParams: formParams
                                                files: files
                                                 body: bodyParam
                                         headerParams: headerParams
                                         authSettings: authSettings
                                   requestContentType: requestContentType
                                  responseContentType: responseContentType
                                         responseType: @"ASPResponseMessage*"
                                      completionBlock: ^(id data, NSError *error) {
                  
                  completionBlock((ASPResponseMessage*)data, error);
              }
          ];
}

///
/// Read document common info.
///
///  @param name The file name.
///
///  @param storage The document storage.
///
///  @param folder The document folder.
///
///  @returns ASPDocumentResponse*
///
-(NSNumber*) getDocumentWithCompletionBlock: (NSString*) name
                                    storage: (NSString*) storage
                                     folder: (NSString*) folder

                          completionHandler: (void (^)(ASPDocumentResponse* output, NSError* error))completionBlock {
    
    
    
    // verify the required parameter 'name' is set
    if (name == nil) {
        [NSException raise:@"Invalid parameter" format:@"Missing the required parameter `name` when calling `getDocument`"];
    }
    
    
    NSMutableString* resourcePath = [NSMutableString stringWithFormat:@"/words/{name}"];
    
    // remove format in URL if needed
    if ([resourcePath rangeOfString:@".{format}"].location != NSNotFound) {
        [resourcePath replaceCharactersInRange: [resourcePath rangeOfString:@".{format}"] withString:@".json"];
    }
    
    NSMutableDictionary *pathParams = [[NSMutableDictionary alloc] init];
    if (name != nil) {
        pathParams[@"name"] = name;
    }
    
    
    NSMutableDictionary* queryParams = [[NSMutableDictionary alloc] init];
    if(storage != nil) {
        
        queryParams[@"storage"] = storage;
    }
    if(folder != nil) {
        
        queryParams[@"folder"] = folder;
    }
    
    NSMutableDictionary* headerParams = [NSMutableDictionary dictionaryWithDictionary:self.defaultHeaders];
    
    
    
    // HTTP header `Accept`
    headerParams[@"Accept"] = [ASPApiClient selectHeaderAccept:@[@"application/json"]];
    if ([headerParams[@"Accept"] length] == 0) {
        [headerParams removeObjectForKey:@"Accept"];
    }
    
    // response content type
    NSString *responseContentType;
    if ([headerParams objectForKey:@"Accept"]) {
        responseContentType = [headerParams[@"Accept"] componentsSeparatedByString:@", "][0];
    }
    else {
        responseContentType = @"";
    }
    
    // request content type
    NSString *requestContentType = [ASPApiClient selectHeaderContentType:@[@"application/json"]];
    
    // Authentication setting
    NSArray *authSettings = @[];
    
    id bodyParam = nil;
    NSMutableDictionary *formParams = [[NSMutableDictionary alloc] init];
    NSMutableDictionary *files = [[NSMutableDictionary alloc] init];
    
    
    
    
    
    return [self.apiClient requestWithCompletionBlock: resourcePath
                                               method: @"GET"
                                           pathParams: pathParams
                                          queryParams: queryParams
                                           formParams: formParams
                                                files: files
                                                 body: bodyParam
                                         headerParams: headerParams
                                         authSettings: authSettings
                                   requestContentType: requestContentType
                                  responseContentType: responseContentType
                                         responseType: @"ASPDocumentResponse*"
                                      completionBlock: ^(id data, NSError *error) {
                                          
                                          completionBlock((ASPDocumentResponse*)data, error);
                                      }
            ];
}

///
/// 
/// 
///  @param name 
///
///  @param format 
///
///  @param storage 
///
///  @param folder 
///
///  @param outPath 
///
///  @returns NSURL*
///
-(NSNumber*) getDocumentWithFormatWithCompletionBlock: (NSString*) name
         format: (NSString*) format
         storage: (NSString*) storage
         folder: (NSString*) folder
         outPath: (NSString*) outPath
        
        completionHandler: (void (^)(NSURL* output, NSError* error))completionBlock { 
        

    
    // verify the required parameter 'name' is set
    if (name == nil) {
        [NSException raise:@"Invalid parameter" format:@"Missing the required parameter `name` when calling `getDocumentWithFormat`"];
    }
    
    // verify the required parameter 'format' is set
    if (format == nil) {
        [NSException raise:@"Invalid parameter" format:@"Missing the required parameter `format` when calling `getDocumentWithFormat`"];
    }
    

    NSMutableString* resourcePath = [NSMutableString stringWithFormat:@"/words/{name}"];

    // remove format in URL if needed
    if ([resourcePath rangeOfString:@".{format}"].location != NSNotFound) {
        [resourcePath replaceCharactersInRange: [resourcePath rangeOfString:@".{format}"] withString:@".json"];
    }

    NSMutableDictionary *pathParams = [[NSMutableDictionary alloc] init];
    if (name != nil) {
        pathParams[@"name"] = name;
    }
    

    NSMutableDictionary* queryParams = [[NSMutableDictionary alloc] init];
    if(format != nil) {
        
        queryParams[@"format"] = format;
    }
    if(storage != nil) {
        
        queryParams[@"storage"] = storage;
    }
    if(folder != nil) {
        
        queryParams[@"folder"] = folder;
    }
    if(outPath != nil) {
        
        queryParams[@"outPath"] = outPath;
    }
    
    NSMutableDictionary* headerParams = [NSMutableDictionary dictionaryWithDictionary:self.defaultHeaders];

    

    // HTTP header `Accept`
    headerParams[@"Accept"] = [ASPApiClient selectHeaderAccept:@[]];
    if ([headerParams[@"Accept"] length] == 0) {
        [headerParams removeObjectForKey:@"Accept"];
    }

    // response content type
    NSString *responseContentType;
    if ([headerParams objectForKey:@"Accept"]) {
        responseContentType = [headerParams[@"Accept"] componentsSeparatedByString:@", "][0];
    }
    else {
        responseContentType = @"";
    }

    // request content type
    NSString *requestContentType = [ASPApiClient selectHeaderContentType:@[@"application/json"]];

    // Authentication setting
    NSArray *authSettings = @[];

    id bodyParam = nil;
    NSMutableDictionary *formParams = [[NSMutableDictionary alloc] init];
    NSMutableDictionary *files = [[NSMutableDictionary alloc] init];
    
    
    

    
    return [self.apiClient requestWithCompletionBlock: resourcePath
                                               method: @"GET"
                                           pathParams: pathParams
                                          queryParams: queryParams
                                           formParams: formParams
                                                files: files
                                                 body: bodyParam
                                         headerParams: headerParams
                                         authSettings: authSettings
                                   requestContentType: requestContentType
                                  responseContentType: responseContentType
                                         responseType: @"NSURL*"
                                      completionBlock: ^(id data, NSError *error) {
                  
                  completionBlock((NSURL*)data, error);
              }
          ];
}

///
/// Convert document to destination format with detailed settings and save result to storage.
/// 
///  @param name The document name.
///
///  @param saveOptionsData Save options.
///
///  @param storage The document storage.
///
///  @param folder The document folder.
///
///  @returns ASPSaveResponse*
///
-(NSNumber*) postDocumentSaveAsWithCompletionBlock: (NSString*) name
         saveOptionsData: (ASPSaveOptionsData*) saveOptionsData
         storage: (NSString*) storage
         folder: (NSString*) folder
        
        completionHandler: (void (^)(ASPSaveResponse* output, NSError* error))completionBlock { 
        

    
    // verify the required parameter 'name' is set
    if (name == nil) {
        [NSException raise:@"Invalid parameter" format:@"Missing the required parameter `name` when calling `postDocumentSaveAs`"];
    }
    
    // verify the required parameter 'saveOptionsData' is set
    if (saveOptionsData == nil) {
        [NSException raise:@"Invalid parameter" format:@"Missing the required parameter `saveOptionsData` when calling `postDocumentSaveAs`"];
    }
    

    NSMutableString* resourcePath = [NSMutableString stringWithFormat:@"/words/{name}/SaveAs"];

    // remove format in URL if needed
    if ([resourcePath rangeOfString:@".{format}"].location != NSNotFound) {
        [resourcePath replaceCharactersInRange: [resourcePath rangeOfString:@".{format}"] withString:@".json"];
    }

    NSMutableDictionary *pathParams = [[NSMutableDictionary alloc] init];
    if (name != nil) {
        pathParams[@"name"] = name;
    }
    

    NSMutableDictionary* queryParams = [[NSMutableDictionary alloc] init];
    if(storage != nil) {
        
        queryParams[@"storage"] = storage;
    }
    if(folder != nil) {
        
        queryParams[@"folder"] = folder;
    }
    
    NSMutableDictionary* headerParams = [NSMutableDictionary dictionaryWithDictionary:self.defaultHeaders];

    

    // HTTP header `Accept`
    headerParams[@"Accept"] = [ASPApiClient selectHeaderAccept:@[@"application/json"]];
    if ([headerParams[@"Accept"] length] == 0) {
        [headerParams removeObjectForKey:@"Accept"];
    }

    // response content type
    NSString *responseContentType;
    if ([headerParams objectForKey:@"Accept"]) {
        responseContentType = [headerParams[@"Accept"] componentsSeparatedByString:@", "][0];
    }
    else {
        responseContentType = @"";
    }

    // request content type
    NSString *requestContentType = [ASPApiClient selectHeaderContentType:@[@"application/json"]];

    // Authentication setting
    NSArray *authSettings = @[];

    id bodyParam = nil;
    NSMutableDictionary *formParams = [[NSMutableDictionary alloc] init];
    NSMutableDictionary *files = [[NSMutableDictionary alloc] init];
    
    bodyParam = saveOptionsData;
    

    
    return [self.apiClient requestWithCompletionBlock: resourcePath
                                               method: @"POST"
                                           pathParams: pathParams
                                          queryParams: queryParams
                                           formParams: formParams
                                                files: files
                                                 body: bodyParam
                                         headerParams: headerParams
                                         authSettings: authSettings
                                   requestContentType: requestContentType
                                  responseContentType: responseContentType
                                         responseType: @"ASPSaveResponse*"
                                      completionBlock: ^(id data, NSError *error) {
                  
                  completionBlock((ASPSaveResponse*)data, error);
              }
          ];
}

///
/// Convert document to tiff with detailed settings and save result to storage.
/// 
///  @param name The document name.
///
///  @param saveOptions Tiff save options.
///
///  @param resultFile The resulting file name.
///
///  @param useAntiAliasing Use antialiasing flag.
///
///  @param useHighQualityRendering Use high quality flag.
///
///  @param imageBrightness Brightness for the generated images.
///
///  @param imageColorMode Color mode for the generated images.
///
///  @param imageContrast The contrast for the generated images.
///
///  @param numeralFormat The images numeral format.
///
///  @param pageCount Number of pages to render.
///
///  @param pageIndex Page index to start rendering.
///
///  @param paperColor Background image color.
///
///  @param pixelFormat The pixel format of generated images.
///
///  @param resolution The resolution of generated images.
///
///  @param scale Zoom factor for generated images.
///
///  @param tiffCompression The compression tipe.
///
///  @param dmlRenderingMode Optional, default is Fallback.
///
///  @param dmlEffectsRenderingMode Optional, default is Simplified.
///
///  @param tiffBinarizationMethod Optional, Tiff binarization method, possible values are: FloydSteinbergDithering, Threshold.
///
///  @param storage The document storage.
///
///  @param folder The document folder.
///
///  @param zipOutput Optional. A value determining zip output or not.
///
///  @returns ASPSaveResponse*
///
-(NSNumber*) putDocumentSaveAsTiffWithCompletionBlock: (NSString*) name
         saveOptions: (ASPTiffSaveOptionsData*) saveOptions
         resultFile: (NSString*) resultFile
         useAntiAliasing: (NSNumber*) useAntiAliasing
         useHighQualityRendering: (NSNumber*) useHighQualityRendering
         imageBrightness: (NSNumber*) imageBrightness
         imageColorMode: (NSString*) imageColorMode
         imageContrast: (NSNumber*) imageContrast
         numeralFormat: (NSString*) numeralFormat
         pageCount: (NSNumber*) pageCount
         pageIndex: (NSNumber*) pageIndex
         paperColor: (NSString*) paperColor
         pixelFormat: (NSString*) pixelFormat
         resolution: (NSNumber*) resolution
         scale: (NSNumber*) scale
         tiffCompression: (NSString*) tiffCompression
         dmlRenderingMode: (NSString*) dmlRenderingMode
         dmlEffectsRenderingMode: (NSString*) dmlEffectsRenderingMode
         tiffBinarizationMethod: (NSString*) tiffBinarizationMethod
         storage: (NSString*) storage
         folder: (NSString*) folder
         zipOutput: (NSNumber*) zipOutput
        
        completionHandler: (void (^)(ASPSaveResponse* output, NSError* error))completionBlock { 
        

    
    // verify the required parameter 'name' is set
    if (name == nil) {
        [NSException raise:@"Invalid parameter" format:@"Missing the required parameter `name` when calling `putDocumentSaveAsTiff`"];
    }
    
    // verify the required parameter 'saveOptions' is set
    if (saveOptions == nil) {
        [NSException raise:@"Invalid parameter" format:@"Missing the required parameter `saveOptions` when calling `putDocumentSaveAsTiff`"];
    }
    

    NSMutableString* resourcePath = [NSMutableString stringWithFormat:@"/words/{name}/SaveAs/tiff"];

    // remove format in URL if needed
    if ([resourcePath rangeOfString:@".{format}"].location != NSNotFound) {
        [resourcePath replaceCharactersInRange: [resourcePath rangeOfString:@".{format}"] withString:@".json"];
    }

    NSMutableDictionary *pathParams = [[NSMutableDictionary alloc] init];
    if (name != nil) {
        pathParams[@"name"] = name;
    }
    

    NSMutableDictionary* queryParams = [[NSMutableDictionary alloc] init];
    if(resultFile != nil) {
        
        queryParams[@"resultFile"] = resultFile;
    }
    if(useAntiAliasing != nil) {
        
        queryParams[@"useAntiAliasing"] = useAntiAliasing;
    }
    if(useHighQualityRendering != nil) {
        
        queryParams[@"useHighQualityRendering"] = useHighQualityRendering;
    }
    if(imageBrightness != nil) {
        
        queryParams[@"imageBrightness"] = imageBrightness;
    }
    if(imageColorMode != nil) {
        
        queryParams[@"imageColorMode"] = imageColorMode;
    }
    if(imageContrast != nil) {
        
        queryParams[@"imageContrast"] = imageContrast;
    }
    if(numeralFormat != nil) {
        
        queryParams[@"numeralFormat"] = numeralFormat;
    }
    if(pageCount != nil) {
        
        queryParams[@"pageCount"] = pageCount;
    }
    if(pageIndex != nil) {
        
        queryParams[@"pageIndex"] = pageIndex;
    }
    if(paperColor != nil) {
        
        queryParams[@"paperColor"] = paperColor;
    }
    if(pixelFormat != nil) {
        
        queryParams[@"pixelFormat"] = pixelFormat;
    }
    if(resolution != nil) {
        
        queryParams[@"resolution"] = resolution;
    }
    if(scale != nil) {
        
        queryParams[@"scale"] = scale;
    }
    if(tiffCompression != nil) {
        
        queryParams[@"tiffCompression"] = tiffCompression;
    }
    if(dmlRenderingMode != nil) {
        
        queryParams[@"dmlRenderingMode"] = dmlRenderingMode;
    }
    if(dmlEffectsRenderingMode != nil) {
        
        queryParams[@"dmlEffectsRenderingMode"] = dmlEffectsRenderingMode;
    }
    if(tiffBinarizationMethod != nil) {
        
        queryParams[@"tiffBinarizationMethod"] = tiffBinarizationMethod;
    }
    if(storage != nil) {
        
        queryParams[@"storage"] = storage;
    }
    if(folder != nil) {
        
        queryParams[@"folder"] = folder;
    }
    if(zipOutput != nil) {
        
        queryParams[@"zipOutput"] = zipOutput;
    }
    
    NSMutableDictionary* headerParams = [NSMutableDictionary dictionaryWithDictionary:self.defaultHeaders];

    

    // HTTP header `Accept`
    headerParams[@"Accept"] = [ASPApiClient selectHeaderAccept:@[@"application/json"]];
    if ([headerParams[@"Accept"] length] == 0) {
        [headerParams removeObjectForKey:@"Accept"];
    }

    // response content type
    NSString *responseContentType;
    if ([headerParams objectForKey:@"Accept"]) {
        responseContentType = [headerParams[@"Accept"] componentsSeparatedByString:@", "][0];
    }
    else {
        responseContentType = @"";
    }

    // request content type
    NSString *requestContentType = [ASPApiClient selectHeaderContentType:@[@"application/json"]];

    // Authentication setting
    NSArray *authSettings = @[];

    id bodyParam = nil;
    NSMutableDictionary *formParams = [[NSMutableDictionary alloc] init];
    NSMutableDictionary *files = [[NSMutableDictionary alloc] init];
    
    bodyParam = saveOptions;
    

    
    return [self.apiClient requestWithCompletionBlock: resourcePath
                                               method: @"PUT"
                                           pathParams: pathParams
                                          queryParams: queryParams
                                           formParams: formParams
                                                files: files
                                                 body: bodyParam
                                         headerParams: headerParams
                                         authSettings: authSettings
                                   requestContentType: requestContentType
                                  responseContentType: responseContentType
                                         responseType: @"ASPSaveResponse*"
                                      completionBlock: ^(id data, NSError *error) {
                  
                  completionBlock((ASPSaveResponse*)data, error);
              }
          ];
}

///
/// Append documents to original document.
/// 
///  @param name Original document name.
///
///  @param documentList {DocumentEntryList} with a list of documents to append.
///
///  @param filename Result name of the document after the operation. If this parameter is omitted then result of the operation will be saved as the source document
///
///  @param storage Original document storage.
///
///  @param folder Original document folder.
///
///  @returns ASPDocumentResponse*
///
-(NSNumber*) postAppendDocumentWithCompletionBlock: (NSString*) name
         documentList: (ASPDocumentEntryList*) documentList
         filename: (NSString*) filename
         storage: (NSString*) storage
         folder: (NSString*) folder
        
        completionHandler: (void (^)(ASPDocumentResponse* output, NSError* error))completionBlock { 
        

    
    // verify the required parameter 'name' is set
    if (name == nil) {
        [NSException raise:@"Invalid parameter" format:@"Missing the required parameter `name` when calling `postAppendDocument`"];
    }
    
    // verify the required parameter 'documentList' is set
    if (documentList == nil) {
        [NSException raise:@"Invalid parameter" format:@"Missing the required parameter `documentList` when calling `postAppendDocument`"];
    }
    

    NSMutableString* resourcePath = [NSMutableString stringWithFormat:@"/words/{name}/appendDocument"];

    // remove format in URL if needed
    if ([resourcePath rangeOfString:@".{format}"].location != NSNotFound) {
        [resourcePath replaceCharactersInRange: [resourcePath rangeOfString:@".{format}"] withString:@".json"];
    }

    NSMutableDictionary *pathParams = [[NSMutableDictionary alloc] init];
    if (name != nil) {
        pathParams[@"name"] = name;
    }
    

    NSMutableDictionary* queryParams = [[NSMutableDictionary alloc] init];
    if(filename != nil) {
        
        queryParams[@"filename"] = filename;
    }
    if(storage != nil) {
        
        queryParams[@"storage"] = storage;
    }
    if(folder != nil) {
        
        queryParams[@"folder"] = folder;
    }
    
    NSMutableDictionary* headerParams = [NSMutableDictionary dictionaryWithDictionary:self.defaultHeaders];

    

    // HTTP header `Accept`
    headerParams[@"Accept"] = [ASPApiClient selectHeaderAccept:@[@"application/json"]];
    if ([headerParams[@"Accept"] length] == 0) {
        [headerParams removeObjectForKey:@"Accept"];
    }

    // response content type
    NSString *responseContentType;
    if ([headerParams objectForKey:@"Accept"]) {
        responseContentType = [headerParams[@"Accept"] componentsSeparatedByString:@", "][0];
    }
    else {
        responseContentType = @"";
    }

    // request content type
    NSString *requestContentType = [ASPApiClient selectHeaderContentType:@[@"application/json"]];

    // Authentication setting
    NSArray *authSettings = @[];

    id bodyParam = nil;
    NSMutableDictionary *formParams = [[NSMutableDictionary alloc] init];
    NSMutableDictionary *files = [[NSMutableDictionary alloc] init];
    
    bodyParam = documentList;
    

    
    return [self.apiClient requestWithCompletionBlock: resourcePath
                                               method: @"POST"
                                           pathParams: pathParams
                                          queryParams: queryParams
                                           formParams: formParams
                                                files: files
                                                 body: bodyParam
                                         headerParams: headerParams
                                         authSettings: authSettings
                                   requestContentType: requestContentType
                                  responseContentType: responseContentType
                                         responseType: @"ASPDocumentResponse*"
                                      completionBlock: ^(id data, NSError *error) {
                  
                  completionBlock((ASPDocumentResponse*)data, error);
              }
          ];
}

///
/// Read document bookmarks common info.
/// 
///  @param name The document name.
///
///  @param storage The document storage.
///
///  @param folder The document folder.
///
///  @returns ASPBookmarksResponse*
///
-(NSNumber*) getDocumentBookmarksWithCompletionBlock: (NSString*) name
         storage: (NSString*) storage
         folder: (NSString*) folder
        
        completionHandler: (void (^)(ASPBookmarksResponse* output, NSError* error))completionBlock { 
        

    
    // verify the required parameter 'name' is set
    if (name == nil) {
        [NSException raise:@"Invalid parameter" format:@"Missing the required parameter `name` when calling `getDocumentBookmarks`"];
    }
    

    NSMutableString* resourcePath = [NSMutableString stringWithFormat:@"/words/{name}/bookmarks"];

    // remove format in URL if needed
    if ([resourcePath rangeOfString:@".{format}"].location != NSNotFound) {
        [resourcePath replaceCharactersInRange: [resourcePath rangeOfString:@".{format}"] withString:@".json"];
    }

    NSMutableDictionary *pathParams = [[NSMutableDictionary alloc] init];
    if (name != nil) {
        pathParams[@"name"] = name;
    }
    

    NSMutableDictionary* queryParams = [[NSMutableDictionary alloc] init];
    if(storage != nil) {
        
        queryParams[@"storage"] = storage;
    }
    if(folder != nil) {
        
        queryParams[@"folder"] = folder;
    }
    
    NSMutableDictionary* headerParams = [NSMutableDictionary dictionaryWithDictionary:self.defaultHeaders];

    

    // HTTP header `Accept`
    headerParams[@"Accept"] = [ASPApiClient selectHeaderAccept:@[@"application/json"]];
    if ([headerParams[@"Accept"] length] == 0) {
        [headerParams removeObjectForKey:@"Accept"];
    }

    // response content type
    NSString *responseContentType;
    if ([headerParams objectForKey:@"Accept"]) {
        responseContentType = [headerParams[@"Accept"] componentsSeparatedByString:@", "][0];
    }
    else {
        responseContentType = @"";
    }

    // request content type
    NSString *requestContentType = [ASPApiClient selectHeaderContentType:@[@"application/json"]];

    // Authentication setting
    NSArray *authSettings = @[];

    id bodyParam = nil;
    NSMutableDictionary *formParams = [[NSMutableDictionary alloc] init];
    NSMutableDictionary *files = [[NSMutableDictionary alloc] init];
    
    
    

    
    return [self.apiClient requestWithCompletionBlock: resourcePath
                                               method: @"GET"
                                           pathParams: pathParams
                                          queryParams: queryParams
                                           formParams: formParams
                                                files: files
                                                 body: bodyParam
                                         headerParams: headerParams
                                         authSettings: authSettings
                                   requestContentType: requestContentType
                                  responseContentType: responseContentType
                                         responseType: @"ASPBookmarksResponse*"
                                      completionBlock: ^(id data, NSError *error) {
                  
                  completionBlock((ASPBookmarksResponse*)data, error);
              }
          ];
}

///
/// Read document bookmark data by its name.
/// 
///  @param name The document name.
///
///  @param bookmarkName The bookmark name.
///
///  @param storage The document storage.
///
///  @param folder The document folder.
///
///  @returns ASPBookmarkResponse*
///
-(NSNumber*) getDocumentBookmarkByNameWithCompletionBlock: (NSString*) name
         bookmarkName: (NSString*) bookmarkName
         storage: (NSString*) storage
         folder: (NSString*) folder
        
        completionHandler: (void (^)(ASPBookmarkResponse* output, NSError* error))completionBlock { 
        

    
    // verify the required parameter 'name' is set
    if (name == nil) {
        [NSException raise:@"Invalid parameter" format:@"Missing the required parameter `name` when calling `getDocumentBookmarkByName`"];
    }
    
    // verify the required parameter 'bookmarkName' is set
    if (bookmarkName == nil) {
        [NSException raise:@"Invalid parameter" format:@"Missing the required parameter `bookmarkName` when calling `getDocumentBookmarkByName`"];
    }
    

    NSMutableString* resourcePath = [NSMutableString stringWithFormat:@"/words/{name}/bookmarks/{bookmarkName}"];

    // remove format in URL if needed
    if ([resourcePath rangeOfString:@".{format}"].location != NSNotFound) {
        [resourcePath replaceCharactersInRange: [resourcePath rangeOfString:@".{format}"] withString:@".json"];
    }

    NSMutableDictionary *pathParams = [[NSMutableDictionary alloc] init];
    if (name != nil) {
        pathParams[@"name"] = name;
    }
    if (bookmarkName != nil) {
        pathParams[@"bookmarkName"] = bookmarkName;
    }
    

    NSMutableDictionary* queryParams = [[NSMutableDictionary alloc] init];
    if(storage != nil) {
        
        queryParams[@"storage"] = storage;
    }
    if(folder != nil) {
        
        queryParams[@"folder"] = folder;
    }
    
    NSMutableDictionary* headerParams = [NSMutableDictionary dictionaryWithDictionary:self.defaultHeaders];

    

    // HTTP header `Accept`
    headerParams[@"Accept"] = [ASPApiClient selectHeaderAccept:@[@"application/json"]];
    if ([headerParams[@"Accept"] length] == 0) {
        [headerParams removeObjectForKey:@"Accept"];
    }

    // response content type
    NSString *responseContentType;
    if ([headerParams objectForKey:@"Accept"]) {
        responseContentType = [headerParams[@"Accept"] componentsSeparatedByString:@", "][0];
    }
    else {
        responseContentType = @"";
    }

    // request content type
    NSString *requestContentType = [ASPApiClient selectHeaderContentType:@[@"application/json"]];

    // Authentication setting
    NSArray *authSettings = @[];

    id bodyParam = nil;
    NSMutableDictionary *formParams = [[NSMutableDictionary alloc] init];
    NSMutableDictionary *files = [[NSMutableDictionary alloc] init];
    
    
    

    
    return [self.apiClient requestWithCompletionBlock: resourcePath
                                               method: @"GET"
                                           pathParams: pathParams
                                          queryParams: queryParams
                                           formParams: formParams
                                                files: files
                                                 body: bodyParam
                                         headerParams: headerParams
                                         authSettings: authSettings
                                   requestContentType: requestContentType
                                  responseContentType: responseContentType
                                         responseType: @"ASPBookmarkResponse*"
                                      completionBlock: ^(id data, NSError *error) {
                  
                  completionBlock((ASPBookmarkResponse*)data, error);
              }
          ];
}

///
/// Update document bookmark.
/// 
///  @param name The document name.
///
///  @param bookmarkName The bookmark name.
///
///  @param bookmarkData {BookmarkData} with new bookmark data.
///
///  @param filename Result name of the document after the operation. If this parameter is omitted then result of the operation will be saved as the source document
///
///  @param storage The document storage.
///
///  @param folder The document folder.
///
///  @returns ASPBookmarkResponse*
///
-(NSNumber*) postUpdateDocumentBookmarkWithCompletionBlock: (NSString*) name
         bookmarkName: (NSString*) bookmarkName
         bookmarkData: (ASPBookmarkData*) bookmarkData
         filename: (NSString*) filename
         storage: (NSString*) storage
         folder: (NSString*) folder
        
        completionHandler: (void (^)(ASPBookmarkResponse* output, NSError* error))completionBlock { 
        

    
    // verify the required parameter 'name' is set
    if (name == nil) {
        [NSException raise:@"Invalid parameter" format:@"Missing the required parameter `name` when calling `postUpdateDocumentBookmark`"];
    }
    
    // verify the required parameter 'bookmarkName' is set
    if (bookmarkName == nil) {
        [NSException raise:@"Invalid parameter" format:@"Missing the required parameter `bookmarkName` when calling `postUpdateDocumentBookmark`"];
    }
    
    // verify the required parameter 'bookmarkData' is set
    if (bookmarkData == nil) {
        [NSException raise:@"Invalid parameter" format:@"Missing the required parameter `bookmarkData` when calling `postUpdateDocumentBookmark`"];
    }
    

    NSMutableString* resourcePath = [NSMutableString stringWithFormat:@"/words/{name}/bookmarks/{bookmarkName}"];

    // remove format in URL if needed
    if ([resourcePath rangeOfString:@".{format}"].location != NSNotFound) {
        [resourcePath replaceCharactersInRange: [resourcePath rangeOfString:@".{format}"] withString:@".json"];
    }

    NSMutableDictionary *pathParams = [[NSMutableDictionary alloc] init];
    if (name != nil) {
        pathParams[@"name"] = name;
    }
    if (bookmarkName != nil) {
        pathParams[@"bookmarkName"] = bookmarkName;
    }
    

    NSMutableDictionary* queryParams = [[NSMutableDictionary alloc] init];
    if(filename != nil) {
        
        queryParams[@"filename"] = filename;
    }
    if(storage != nil) {
        
        queryParams[@"storage"] = storage;
    }
    if(folder != nil) {
        
        queryParams[@"folder"] = folder;
    }
    
    NSMutableDictionary* headerParams = [NSMutableDictionary dictionaryWithDictionary:self.defaultHeaders];

    

    // HTTP header `Accept`
    headerParams[@"Accept"] = [ASPApiClient selectHeaderAccept:@[@"application/json"]];
    if ([headerParams[@"Accept"] length] == 0) {
        [headerParams removeObjectForKey:@"Accept"];
    }

    // response content type
    NSString *responseContentType;
    if ([headerParams objectForKey:@"Accept"]) {
        responseContentType = [headerParams[@"Accept"] componentsSeparatedByString:@", "][0];
    }
    else {
        responseContentType = @"";
    }

    // request content type
    NSString *requestContentType = [ASPApiClient selectHeaderContentType:@[@"application/json"]];

    // Authentication setting
    NSArray *authSettings = @[];

    id bodyParam = nil;
    NSMutableDictionary *formParams = [[NSMutableDictionary alloc] init];
    NSMutableDictionary *files = [[NSMutableDictionary alloc] init];
    
    bodyParam = bookmarkData;
    

    
    return [self.apiClient requestWithCompletionBlock: resourcePath
                                               method: @"POST"
                                           pathParams: pathParams
                                          queryParams: queryParams
                                           formParams: formParams
                                                files: files
                                                 body: bodyParam
                                         headerParams: headerParams
                                         authSettings: authSettings
                                   requestContentType: requestContentType
                                  responseContentType: responseContentType
                                         responseType: @"ASPBookmarkResponse*"
                                      completionBlock: ^(id data, NSError *error) {
                  
                  completionBlock((ASPBookmarkResponse*)data, error);
              }
          ];
}

///
/// Get comments from document.
/// 
///  @param name The file name.
///
///  @param storage The document storage.
///
///  @param folder The document folder.
///
///  @returns ASPCommentsResponse*
///
-(NSNumber*) getCommentsWithCompletionBlock: (NSString*) name
         storage: (NSString*) storage
         folder: (NSString*) folder
        
        completionHandler: (void (^)(ASPCommentsResponse* output, NSError* error))completionBlock { 
        

    
    // verify the required parameter 'name' is set
    if (name == nil) {
        [NSException raise:@"Invalid parameter" format:@"Missing the required parameter `name` when calling `getComments`"];
    }
    

    NSMutableString* resourcePath = [NSMutableString stringWithFormat:@"/words/{name}/comments"];

    // remove format in URL if needed
    if ([resourcePath rangeOfString:@".{format}"].location != NSNotFound) {
        [resourcePath replaceCharactersInRange: [resourcePath rangeOfString:@".{format}"] withString:@".json"];
    }

    NSMutableDictionary *pathParams = [[NSMutableDictionary alloc] init];
    if (name != nil) {
        pathParams[@"name"] = name;
    }
    

    NSMutableDictionary* queryParams = [[NSMutableDictionary alloc] init];
    if(storage != nil) {
        
        queryParams[@"storage"] = storage;
    }
    if(folder != nil) {
        
        queryParams[@"folder"] = folder;
    }
    
    NSMutableDictionary* headerParams = [NSMutableDictionary dictionaryWithDictionary:self.defaultHeaders];

    

    // HTTP header `Accept`
    headerParams[@"Accept"] = [ASPApiClient selectHeaderAccept:@[@"application/json"]];
    if ([headerParams[@"Accept"] length] == 0) {
        [headerParams removeObjectForKey:@"Accept"];
    }

    // response content type
    NSString *responseContentType;
    if ([headerParams objectForKey:@"Accept"]) {
        responseContentType = [headerParams[@"Accept"] componentsSeparatedByString:@", "][0];
    }
    else {
        responseContentType = @"";
    }

    // request content type
    NSString *requestContentType = [ASPApiClient selectHeaderContentType:@[@"application/json"]];

    // Authentication setting
    NSArray *authSettings = @[];

    id bodyParam = nil;
    NSMutableDictionary *formParams = [[NSMutableDictionary alloc] init];
    NSMutableDictionary *files = [[NSMutableDictionary alloc] init];
    
    
    

    
    return [self.apiClient requestWithCompletionBlock: resourcePath
                                               method: @"GET"
                                           pathParams: pathParams
                                          queryParams: queryParams
                                           formParams: formParams
                                                files: files
                                                 body: bodyParam
                                         headerParams: headerParams
                                         authSettings: authSettings
                                   requestContentType: requestContentType
                                  responseContentType: responseContentType
                                         responseType: @"ASPCommentsResponse*"
                                      completionBlock: ^(id data, NSError *error) {
                  
                  completionBlock((ASPCommentsResponse*)data, error);
              }
          ];
}

///
/// Adds comment to document, returns inserted comment's data.
/// 
///  @param name The document name.
///
///  @param comment Comment data.
///
///  @param fileName Destination file name.
///
///  @param storage The document storage.
///
///  @param folder The document folder.
///
///  @returns ASPCommentResponse*
///
-(NSNumber*) putCommentWithCompletionBlock: (NSString*) name
         comment: (ASPComment*) comment
         fileName: (NSString*) fileName
         storage: (NSString*) storage
         folder: (NSString*) folder
        
        completionHandler: (void (^)(ASPCommentResponse* output, NSError* error))completionBlock { 
        

    
    // verify the required parameter 'name' is set
    if (name == nil) {
        [NSException raise:@"Invalid parameter" format:@"Missing the required parameter `name` when calling `putComment`"];
    }
    
    // verify the required parameter 'comment' is set
    if (comment == nil) {
        [NSException raise:@"Invalid parameter" format:@"Missing the required parameter `comment` when calling `putComment`"];
    }
    

    NSMutableString* resourcePath = [NSMutableString stringWithFormat:@"/words/{name}/comments"];

    // remove format in URL if needed
    if ([resourcePath rangeOfString:@".{format}"].location != NSNotFound) {
        [resourcePath replaceCharactersInRange: [resourcePath rangeOfString:@".{format}"] withString:@".json"];
    }

    NSMutableDictionary *pathParams = [[NSMutableDictionary alloc] init];
    if (name != nil) {
        pathParams[@"name"] = name;
    }
    

    NSMutableDictionary* queryParams = [[NSMutableDictionary alloc] init];
    if(fileName != nil) {
        
        queryParams[@"fileName"] = fileName;
    }
    if(storage != nil) {
        
        queryParams[@"storage"] = storage;
    }
    if(folder != nil) {
        
        queryParams[@"folder"] = folder;
    }
    
    NSMutableDictionary* headerParams = [NSMutableDictionary dictionaryWithDictionary:self.defaultHeaders];

    

    // HTTP header `Accept`
    headerParams[@"Accept"] = [ASPApiClient selectHeaderAccept:@[@"application/json"]];
    if ([headerParams[@"Accept"] length] == 0) {
        [headerParams removeObjectForKey:@"Accept"];
    }

    // response content type
    NSString *responseContentType;
    if ([headerParams objectForKey:@"Accept"]) {
        responseContentType = [headerParams[@"Accept"] componentsSeparatedByString:@", "][0];
    }
    else {
        responseContentType = @"";
    }

    // request content type
    NSString *requestContentType = [ASPApiClient selectHeaderContentType:@[@"application/json"]];

    // Authentication setting
    NSArray *authSettings = @[];

    id bodyParam = nil;
    NSMutableDictionary *formParams = [[NSMutableDictionary alloc] init];
    NSMutableDictionary *files = [[NSMutableDictionary alloc] init];
    
    bodyParam = comment;
    

    
    return [self.apiClient requestWithCompletionBlock: resourcePath
                                               method: @"PUT"
                                           pathParams: pathParams
                                          queryParams: queryParams
                                           formParams: formParams
                                                files: files
                                                 body: bodyParam
                                         headerParams: headerParams
                                         authSettings: authSettings
                                   requestContentType: requestContentType
                                  responseContentType: responseContentType
                                         responseType: @"ASPCommentResponse*"
                                      completionBlock: ^(id data, NSError *error) {
                  
                  completionBlock((ASPCommentResponse*)data, error);
              }
          ];
}

///
/// Get comment from document.
/// 
///  @param name The file name.
///
///  @param commentIndex Comment index
///
///  @param storage The document storage.
///
///  @param folder The document folder.
///
///  @returns ASPCommentResponse*
///
-(NSNumber*) getCommentWithCompletionBlock: (NSString*) name
         commentIndex: (NSNumber*) commentIndex
         storage: (NSString*) storage
         folder: (NSString*) folder
        
        completionHandler: (void (^)(ASPCommentResponse* output, NSError* error))completionBlock { 
        

    
    // verify the required parameter 'name' is set
    if (name == nil) {
        [NSException raise:@"Invalid parameter" format:@"Missing the required parameter `name` when calling `getComment`"];
    }
    
    // verify the required parameter 'commentIndex' is set
    if (commentIndex == nil) {
        [NSException raise:@"Invalid parameter" format:@"Missing the required parameter `commentIndex` when calling `getComment`"];
    }
    

    NSMutableString* resourcePath = [NSMutableString stringWithFormat:@"/words/{name}/comments/{commentIndex}"];

    // remove format in URL if needed
    if ([resourcePath rangeOfString:@".{format}"].location != NSNotFound) {
        [resourcePath replaceCharactersInRange: [resourcePath rangeOfString:@".{format}"] withString:@".json"];
    }

    NSMutableDictionary *pathParams = [[NSMutableDictionary alloc] init];
    if (name != nil) {
        pathParams[@"name"] = name;
    }
    if (commentIndex != nil) {
        pathParams[@"commentIndex"] = commentIndex;
    }
    

    NSMutableDictionary* queryParams = [[NSMutableDictionary alloc] init];
    if(storage != nil) {
        
        queryParams[@"storage"] = storage;
    }
    if(folder != nil) {
        
        queryParams[@"folder"] = folder;
    }
    
    NSMutableDictionary* headerParams = [NSMutableDictionary dictionaryWithDictionary:self.defaultHeaders];

    

    // HTTP header `Accept`
    headerParams[@"Accept"] = [ASPApiClient selectHeaderAccept:@[@"application/json"]];
    if ([headerParams[@"Accept"] length] == 0) {
        [headerParams removeObjectForKey:@"Accept"];
    }

    // response content type
    NSString *responseContentType;
    if ([headerParams objectForKey:@"Accept"]) {
        responseContentType = [headerParams[@"Accept"] componentsSeparatedByString:@", "][0];
    }
    else {
        responseContentType = @"";
    }

    // request content type
    NSString *requestContentType = [ASPApiClient selectHeaderContentType:@[@"application/json"]];

    // Authentication setting
    NSArray *authSettings = @[];

    id bodyParam = nil;
    NSMutableDictionary *formParams = [[NSMutableDictionary alloc] init];
    NSMutableDictionary *files = [[NSMutableDictionary alloc] init];
    
    
    

    
    return [self.apiClient requestWithCompletionBlock: resourcePath
                                               method: @"GET"
                                           pathParams: pathParams
                                          queryParams: queryParams
                                           formParams: formParams
                                                files: files
                                                 body: bodyParam
                                         headerParams: headerParams
                                         authSettings: authSettings
                                   requestContentType: requestContentType
                                  responseContentType: responseContentType
                                         responseType: @"ASPCommentResponse*"
                                      completionBlock: ^(id data, NSError *error) {
                  
                  completionBlock((ASPCommentResponse*)data, error);
              }
          ];
}

///
/// Updates the comment, returns updated comment's data.
/// 
///  @param name The document name.
///
///  @param commentIndex Comment index
///
///  @param comment Comment data.
///
///  @param fileName Destination file name.
///
///  @param storage The document storage.
///
///  @param folder The document folder.
///
///  @returns ASPCommentResponse*
///
-(NSNumber*) postCommentWithCompletionBlock: (NSString*) name
         commentIndex: (NSNumber*) commentIndex
         comment: (ASPComment*) comment
         fileName: (NSString*) fileName
         storage: (NSString*) storage
         folder: (NSString*) folder
        
        completionHandler: (void (^)(ASPCommentResponse* output, NSError* error))completionBlock { 
        

    
    // verify the required parameter 'name' is set
    if (name == nil) {
        [NSException raise:@"Invalid parameter" format:@"Missing the required parameter `name` when calling `postComment`"];
    }
    
    // verify the required parameter 'commentIndex' is set
    if (commentIndex == nil) {
        [NSException raise:@"Invalid parameter" format:@"Missing the required parameter `commentIndex` when calling `postComment`"];
    }
    
    // verify the required parameter 'comment' is set
    if (comment == nil) {
        [NSException raise:@"Invalid parameter" format:@"Missing the required parameter `comment` when calling `postComment`"];
    }
    

    NSMutableString* resourcePath = [NSMutableString stringWithFormat:@"/words/{name}/comments/{commentIndex}"];

    // remove format in URL if needed
    if ([resourcePath rangeOfString:@".{format}"].location != NSNotFound) {
        [resourcePath replaceCharactersInRange: [resourcePath rangeOfString:@".{format}"] withString:@".json"];
    }

    NSMutableDictionary *pathParams = [[NSMutableDictionary alloc] init];
    if (name != nil) {
        pathParams[@"name"] = name;
    }
    if (commentIndex != nil) {
        pathParams[@"commentIndex"] = commentIndex;
    }
    

    NSMutableDictionary* queryParams = [[NSMutableDictionary alloc] init];
    if(fileName != nil) {
        
        queryParams[@"fileName"] = fileName;
    }
    if(storage != nil) {
        
        queryParams[@"storage"] = storage;
    }
    if(folder != nil) {
        
        queryParams[@"folder"] = folder;
    }
    
    NSMutableDictionary* headerParams = [NSMutableDictionary dictionaryWithDictionary:self.defaultHeaders];

    

    // HTTP header `Accept`
    headerParams[@"Accept"] = [ASPApiClient selectHeaderAccept:@[@"application/json"]];
    if ([headerParams[@"Accept"] length] == 0) {
        [headerParams removeObjectForKey:@"Accept"];
    }

    // response content type
    NSString *responseContentType;
    if ([headerParams objectForKey:@"Accept"]) {
        responseContentType = [headerParams[@"Accept"] componentsSeparatedByString:@", "][0];
    }
    else {
        responseContentType = @"";
    }

    // request content type
    NSString *requestContentType = [ASPApiClient selectHeaderContentType:@[@"application/json"]];

    // Authentication setting
    NSArray *authSettings = @[];

    id bodyParam = nil;
    NSMutableDictionary *formParams = [[NSMutableDictionary alloc] init];
    NSMutableDictionary *files = [[NSMutableDictionary alloc] init];
    
    bodyParam = comment;
    

    
    return [self.apiClient requestWithCompletionBlock: resourcePath
                                               method: @"POST"
                                           pathParams: pathParams
                                          queryParams: queryParams
                                           formParams: formParams
                                                files: files
                                                 body: bodyParam
                                         headerParams: headerParams
                                         authSettings: authSettings
                                   requestContentType: requestContentType
                                  responseContentType: responseContentType
                                         responseType: @"ASPCommentResponse*"
                                      completionBlock: ^(id data, NSError *error) {
                  
                  completionBlock((ASPCommentResponse*)data, error);
              }
          ];
}

///
/// Remove comment from document.
/// 
///  @param name The file name.
///
///  @param commentIndex Comment index
///
///  @param storage The document storage.
///
///  @param folder The document folder.
///
///  @param fileName Result name of the document after the operation. If this parameter is omitted then result of the operation will be saved as the source document.
///
///  @returns ASPBaseResponse*
///
-(NSNumber*) deleteCommentWithCompletionBlock: (NSString*) name
         commentIndex: (NSNumber*) commentIndex
         storage: (NSString*) storage
         folder: (NSString*) folder
         fileName: (NSString*) fileName
        
        completionHandler: (void (^)(ASPBaseResponse* output, NSError* error))completionBlock { 
        

    
    // verify the required parameter 'name' is set
    if (name == nil) {
        [NSException raise:@"Invalid parameter" format:@"Missing the required parameter `name` when calling `deleteComment`"];
    }
    
    // verify the required parameter 'commentIndex' is set
    if (commentIndex == nil) {
        [NSException raise:@"Invalid parameter" format:@"Missing the required parameter `commentIndex` when calling `deleteComment`"];
    }
    

    NSMutableString* resourcePath = [NSMutableString stringWithFormat:@"/words/{name}/comments/{commentIndex}"];

    // remove format in URL if needed
    if ([resourcePath rangeOfString:@".{format}"].location != NSNotFound) {
        [resourcePath replaceCharactersInRange: [resourcePath rangeOfString:@".{format}"] withString:@".json"];
    }

    NSMutableDictionary *pathParams = [[NSMutableDictionary alloc] init];
    if (name != nil) {
        pathParams[@"name"] = name;
    }
    if (commentIndex != nil) {
        pathParams[@"commentIndex"] = commentIndex;
    }
    

    NSMutableDictionary* queryParams = [[NSMutableDictionary alloc] init];
    if(storage != nil) {
        
        queryParams[@"storage"] = storage;
    }
    if(folder != nil) {
        
        queryParams[@"folder"] = folder;
    }
    if(fileName != nil) {
        
        queryParams[@"fileName"] = fileName;
    }
    
    NSMutableDictionary* headerParams = [NSMutableDictionary dictionaryWithDictionary:self.defaultHeaders];

    

    // HTTP header `Accept`
    headerParams[@"Accept"] = [ASPApiClient selectHeaderAccept:@[@"application/json"]];
    if ([headerParams[@"Accept"] length] == 0) {
        [headerParams removeObjectForKey:@"Accept"];
    }

    // response content type
    NSString *responseContentType;
    if ([headerParams objectForKey:@"Accept"]) {
        responseContentType = [headerParams[@"Accept"] componentsSeparatedByString:@", "][0];
    }
    else {
        responseContentType = @"";
    }

    // request content type
    NSString *requestContentType = [ASPApiClient selectHeaderContentType:@[@"application/json"]];

    // Authentication setting
    NSArray *authSettings = @[];

    id bodyParam = nil;
    NSMutableDictionary *formParams = [[NSMutableDictionary alloc] init];
    NSMutableDictionary *files = [[NSMutableDictionary alloc] init];
    
    
    

    
    return [self.apiClient requestWithCompletionBlock: resourcePath
                                               method: @"DELETE"
                                           pathParams: pathParams
                                          queryParams: queryParams
                                           formParams: formParams
                                                files: files
                                                 body: bodyParam
                                         headerParams: headerParams
                                         authSettings: authSettings
                                   requestContentType: requestContentType
                                  responseContentType: responseContentType
                                         responseType: @"ASPBaseResponse*"
                                      completionBlock: ^(id data, NSError *error) {
                  
                  completionBlock((ASPBaseResponse*)data, error);
              }
          ];
}

///
/// Read document properties info.
/// 
///  @param name The document's name.
///
///  @param storage The document's storage.
///
///  @param folder The document's folder.
///
///  @returns ASPDocumentPropertiesResponse*
///
-(NSNumber*) getDocumentPropertiesWithCompletionBlock: (NSString*) name
         storage: (NSString*) storage
         folder: (NSString*) folder
        
        completionHandler: (void (^)(ASPDocumentPropertiesResponse* output, NSError* error))completionBlock { 
        

    
    // verify the required parameter 'name' is set
    if (name == nil) {
        [NSException raise:@"Invalid parameter" format:@"Missing the required parameter `name` when calling `getDocumentProperties`"];
    }
    

    NSMutableString* resourcePath = [NSMutableString stringWithFormat:@"/words/{name}/documentProperties"];

    // remove format in URL if needed
    if ([resourcePath rangeOfString:@".{format}"].location != NSNotFound) {
        [resourcePath replaceCharactersInRange: [resourcePath rangeOfString:@".{format}"] withString:@".json"];
    }

    NSMutableDictionary *pathParams = [[NSMutableDictionary alloc] init];
    if (name != nil) {
        pathParams[@"name"] = name;
    }
    

    NSMutableDictionary* queryParams = [[NSMutableDictionary alloc] init];
    if(storage != nil) {
        
        queryParams[@"storage"] = storage;
    }
    if(folder != nil) {
        
        queryParams[@"folder"] = folder;
    }
    
    NSMutableDictionary* headerParams = [NSMutableDictionary dictionaryWithDictionary:self.defaultHeaders];

    

    // HTTP header `Accept`
    headerParams[@"Accept"] = [ASPApiClient selectHeaderAccept:@[@"application/json"]];
    if ([headerParams[@"Accept"] length] == 0) {
        [headerParams removeObjectForKey:@"Accept"];
    }

    // response content type
    NSString *responseContentType;
    if ([headerParams objectForKey:@"Accept"]) {
        responseContentType = [headerParams[@"Accept"] componentsSeparatedByString:@", "][0];
    }
    else {
        responseContentType = @"";
    }

    // request content type
    NSString *requestContentType = [ASPApiClient selectHeaderContentType:@[@"application/json"]];

    // Authentication setting
    NSArray *authSettings = @[];

    id bodyParam = nil;
    NSMutableDictionary *formParams = [[NSMutableDictionary alloc] init];
    NSMutableDictionary *files = [[NSMutableDictionary alloc] init];
    
    
    

    
    return [self.apiClient requestWithCompletionBlock: resourcePath
                                               method: @"GET"
                                           pathParams: pathParams
                                          queryParams: queryParams
                                           formParams: formParams
                                                files: files
                                                 body: bodyParam
                                         headerParams: headerParams
                                         authSettings: authSettings
                                   requestContentType: requestContentType
                                  responseContentType: responseContentType
                                         responseType: @"ASPDocumentPropertiesResponse*"
                                      completionBlock: ^(id data, NSError *error) {
                  
                  completionBlock((ASPDocumentPropertiesResponse*)data, error);
              }
          ];
}

///
/// Read document property info by the property name.
/// 
///  @param name The document name.
///
///  @param propertyName The property name.
///
///  @param storage The document storage.
///
///  @param folder The document folder.
///
///  @returns ASPDocumentPropertyResponse*
///
-(NSNumber*) getDocumentPropertyWithCompletionBlock: (NSString*) name
         propertyName: (NSString*) propertyName
         storage: (NSString*) storage
         folder: (NSString*) folder
        
        completionHandler: (void (^)(ASPDocumentPropertyResponse* output, NSError* error))completionBlock { 
        

    
    // verify the required parameter 'name' is set
    if (name == nil) {
        [NSException raise:@"Invalid parameter" format:@"Missing the required parameter `name` when calling `getDocumentProperty`"];
    }
    
    // verify the required parameter 'propertyName' is set
    if (propertyName == nil) {
        [NSException raise:@"Invalid parameter" format:@"Missing the required parameter `propertyName` when calling `getDocumentProperty`"];
    }
    

    NSMutableString* resourcePath = [NSMutableString stringWithFormat:@"/words/{name}/documentProperties/{propertyName}"];

    // remove format in URL if needed
    if ([resourcePath rangeOfString:@".{format}"].location != NSNotFound) {
        [resourcePath replaceCharactersInRange: [resourcePath rangeOfString:@".{format}"] withString:@".json"];
    }

    NSMutableDictionary *pathParams = [[NSMutableDictionary alloc] init];
    if (name != nil) {
        pathParams[@"name"] = name;
    }
    if (propertyName != nil) {
        pathParams[@"propertyName"] = propertyName;
    }
    

    NSMutableDictionary* queryParams = [[NSMutableDictionary alloc] init];
    if(storage != nil) {
        
        queryParams[@"storage"] = storage;
    }
    if(folder != nil) {
        
        queryParams[@"folder"] = folder;
    }
    
    NSMutableDictionary* headerParams = [NSMutableDictionary dictionaryWithDictionary:self.defaultHeaders];

    

    // HTTP header `Accept`
    headerParams[@"Accept"] = [ASPApiClient selectHeaderAccept:@[@"application/json"]];
    if ([headerParams[@"Accept"] length] == 0) {
        [headerParams removeObjectForKey:@"Accept"];
    }

    // response content type
    NSString *responseContentType;
    if ([headerParams objectForKey:@"Accept"]) {
        responseContentType = [headerParams[@"Accept"] componentsSeparatedByString:@", "][0];
    }
    else {
        responseContentType = @"";
    }

    // request content type
    NSString *requestContentType = [ASPApiClient selectHeaderContentType:@[@"application/json"]];

    // Authentication setting
    NSArray *authSettings = @[];

    id bodyParam = nil;
    NSMutableDictionary *formParams = [[NSMutableDictionary alloc] init];
    NSMutableDictionary *files = [[NSMutableDictionary alloc] init];
    
    
    

    
    return [self.apiClient requestWithCompletionBlock: resourcePath
                                               method: @"GET"
                                           pathParams: pathParams
                                          queryParams: queryParams
                                           formParams: formParams
                                                files: files
                                                 body: bodyParam
                                         headerParams: headerParams
                                         authSettings: authSettings
                                   requestContentType: requestContentType
                                  responseContentType: responseContentType
                                         responseType: @"ASPDocumentPropertyResponse*"
                                      completionBlock: ^(id data, NSError *error) {
                  
                  completionBlock((ASPDocumentPropertyResponse*)data, error);
              }
          ];
}

///
/// Add new or update existing document property.
/// 
///  @param name The document name.
///
///  @param propertyName The property name.
///
///  @param _property The property with new value.
///
///  @param filename Result name of the document after the operation. If this parameter is omitted then result of the operation will be saved as the source document
///
///  @param storage Document's storage.
///
///  @param folder Document's folder.
///
///  @returns ASPDocumentPropertyResponse*
///
-(NSNumber*) putUpdateDocumentPropertyWithCompletionBlock: (NSString*) name
         propertyName: (NSString*) propertyName
         _property: (ASPDocumentProperty*) _property
         filename: (NSString*) filename
         storage: (NSString*) storage
         folder: (NSString*) folder
        
        completionHandler: (void (^)(ASPDocumentPropertyResponse* output, NSError* error))completionBlock { 
        

    
    // verify the required parameter 'name' is set
    if (name == nil) {
        [NSException raise:@"Invalid parameter" format:@"Missing the required parameter `name` when calling `putUpdateDocumentProperty`"];
    }
    
    // verify the required parameter 'propertyName' is set
    if (propertyName == nil) {
        [NSException raise:@"Invalid parameter" format:@"Missing the required parameter `propertyName` when calling `putUpdateDocumentProperty`"];
    }
    
    // verify the required parameter '_property' is set
    if (_property == nil) {
        [NSException raise:@"Invalid parameter" format:@"Missing the required parameter `_property` when calling `putUpdateDocumentProperty`"];
    }
    

    NSMutableString* resourcePath = [NSMutableString stringWithFormat:@"/words/{name}/documentProperties/{propertyName}"];

    // remove format in URL if needed
    if ([resourcePath rangeOfString:@".{format}"].location != NSNotFound) {
        [resourcePath replaceCharactersInRange: [resourcePath rangeOfString:@".{format}"] withString:@".json"];
    }

    NSMutableDictionary *pathParams = [[NSMutableDictionary alloc] init];
    if (name != nil) {
        pathParams[@"name"] = name;
    }
    if (propertyName != nil) {
        pathParams[@"propertyName"] = propertyName;
    }
    

    NSMutableDictionary* queryParams = [[NSMutableDictionary alloc] init];
    if(filename != nil) {
        
        queryParams[@"filename"] = filename;
    }
    if(storage != nil) {
        
        queryParams[@"storage"] = storage;
    }
    if(folder != nil) {
        
        queryParams[@"folder"] = folder;
    }
    
    NSMutableDictionary* headerParams = [NSMutableDictionary dictionaryWithDictionary:self.defaultHeaders];

    

    // HTTP header `Accept`
    headerParams[@"Accept"] = [ASPApiClient selectHeaderAccept:@[@"application/json"]];
    if ([headerParams[@"Accept"] length] == 0) {
        [headerParams removeObjectForKey:@"Accept"];
    }

    // response content type
    NSString *responseContentType;
    if ([headerParams objectForKey:@"Accept"]) {
        responseContentType = [headerParams[@"Accept"] componentsSeparatedByString:@", "][0];
    }
    else {
        responseContentType = @"";
    }

    // request content type
    NSString *requestContentType = [ASPApiClient selectHeaderContentType:@[@"application/json"]];

    // Authentication setting
    NSArray *authSettings = @[];

    id bodyParam = nil;
    NSMutableDictionary *formParams = [[NSMutableDictionary alloc] init];
    NSMutableDictionary *files = [[NSMutableDictionary alloc] init];
    
    bodyParam = _property;
    

    
    return [self.apiClient requestWithCompletionBlock: resourcePath
                                               method: @"PUT"
                                           pathParams: pathParams
                                          queryParams: queryParams
                                           formParams: formParams
                                                files: files
                                                 body: bodyParam
                                         headerParams: headerParams
                                         authSettings: authSettings
                                   requestContentType: requestContentType
                                  responseContentType: responseContentType
                                         responseType: @"ASPDocumentPropertyResponse*"
                                      completionBlock: ^(id data, NSError *error) {
                  
                  completionBlock((ASPDocumentPropertyResponse*)data, error);
              }
          ];
}

///
/// Delete document property.
/// 
///  @param name The document name.
///
///  @param propertyName The property name.
///
///  @param filename Result name of the document after the operation. If this parameter is omitted then result of the operation will be saved as the source document
///
///  @param storage Document's storage.
///
///  @param folder Document's folder.
///
///  @returns ASPBaseResponse*
///
-(NSNumber*) deleteDocumentPropertyWithCompletionBlock: (NSString*) name
         propertyName: (NSString*) propertyName
         filename: (NSString*) filename
         storage: (NSString*) storage
         folder: (NSString*) folder
        
        completionHandler: (void (^)(ASPBaseResponse* output, NSError* error))completionBlock { 
        

    
    // verify the required parameter 'name' is set
    if (name == nil) {
        [NSException raise:@"Invalid parameter" format:@"Missing the required parameter `name` when calling `deleteDocumentProperty`"];
    }
    
    // verify the required parameter 'propertyName' is set
    if (propertyName == nil) {
        [NSException raise:@"Invalid parameter" format:@"Missing the required parameter `propertyName` when calling `deleteDocumentProperty`"];
    }
    

    NSMutableString* resourcePath = [NSMutableString stringWithFormat:@"/words/{name}/documentProperties/{propertyName}"];

    // remove format in URL if needed
    if ([resourcePath rangeOfString:@".{format}"].location != NSNotFound) {
        [resourcePath replaceCharactersInRange: [resourcePath rangeOfString:@".{format}"] withString:@".json"];
    }

    NSMutableDictionary *pathParams = [[NSMutableDictionary alloc] init];
    if (name != nil) {
        pathParams[@"name"] = name;
    }
    if (propertyName != nil) {
        pathParams[@"propertyName"] = propertyName;
    }
    

    NSMutableDictionary* queryParams = [[NSMutableDictionary alloc] init];
    if(filename != nil) {
        
        queryParams[@"filename"] = filename;
    }
    if(storage != nil) {
        
        queryParams[@"storage"] = storage;
    }
    if(folder != nil) {
        
        queryParams[@"folder"] = folder;
    }
    
    NSMutableDictionary* headerParams = [NSMutableDictionary dictionaryWithDictionary:self.defaultHeaders];

    

    // HTTP header `Accept`
    headerParams[@"Accept"] = [ASPApiClient selectHeaderAccept:@[@"application/json"]];
    if ([headerParams[@"Accept"] length] == 0) {
        [headerParams removeObjectForKey:@"Accept"];
    }

    // response content type
    NSString *responseContentType;
    if ([headerParams objectForKey:@"Accept"]) {
        responseContentType = [headerParams[@"Accept"] componentsSeparatedByString:@", "][0];
    }
    else {
        responseContentType = @"";
    }

    // request content type
    NSString *requestContentType = [ASPApiClient selectHeaderContentType:@[@"application/json"]];

    // Authentication setting
    NSArray *authSettings = @[];

    id bodyParam = nil;
    NSMutableDictionary *formParams = [[NSMutableDictionary alloc] init];
    NSMutableDictionary *files = [[NSMutableDictionary alloc] init];
    
    
    

    
    return [self.apiClient requestWithCompletionBlock: resourcePath
                                               method: @"DELETE"
                                           pathParams: pathParams
                                          queryParams: queryParams
                                           formParams: formParams
                                                files: files
                                                 body: bodyParam
                                         headerParams: headerParams
                                         authSettings: authSettings
                                   requestContentType: requestContentType
                                  responseContentType: responseContentType
                                         responseType: @"ASPBaseResponse*"
                                      completionBlock: ^(id data, NSError *error) {
                  
                  completionBlock((ASPBaseResponse*)data, error);
              }
          ];
}

///
/// Read document drawing objects common info.
/// 
///  @param name The document name.
///
///  @param storage The document storage.
///
///  @param folder The document folder.
///
///  @returns ASPDrawingObjectsResponse*
///
-(NSNumber*) getDocumentDrawingObjectsWithCompletionBlock: (NSString*) name
         storage: (NSString*) storage
         folder: (NSString*) folder
        
        completionHandler: (void (^)(ASPDrawingObjectsResponse* output, NSError* error))completionBlock { 
        

    
    // verify the required parameter 'name' is set
    if (name == nil) {
        [NSException raise:@"Invalid parameter" format:@"Missing the required parameter `name` when calling `getDocumentDrawingObjects`"];
    }
    

    NSMutableString* resourcePath = [NSMutableString stringWithFormat:@"/words/{name}/drawingObjects"];

    // remove format in URL if needed
    if ([resourcePath rangeOfString:@".{format}"].location != NSNotFound) {
        [resourcePath replaceCharactersInRange: [resourcePath rangeOfString:@".{format}"] withString:@".json"];
    }

    NSMutableDictionary *pathParams = [[NSMutableDictionary alloc] init];
    if (name != nil) {
        pathParams[@"name"] = name;
    }
    

    NSMutableDictionary* queryParams = [[NSMutableDictionary alloc] init];
    if(storage != nil) {
        
        queryParams[@"storage"] = storage;
    }
    if(folder != nil) {
        
        queryParams[@"folder"] = folder;
    }
    
    NSMutableDictionary* headerParams = [NSMutableDictionary dictionaryWithDictionary:self.defaultHeaders];

    

    // HTTP header `Accept`
    headerParams[@"Accept"] = [ASPApiClient selectHeaderAccept:@[@"application/json"]];
    if ([headerParams[@"Accept"] length] == 0) {
        [headerParams removeObjectForKey:@"Accept"];
    }

    // response content type
    NSString *responseContentType;
    if ([headerParams objectForKey:@"Accept"]) {
        responseContentType = [headerParams[@"Accept"] componentsSeparatedByString:@", "][0];
    }
    else {
        responseContentType = @"";
    }

    // request content type
    NSString *requestContentType = [ASPApiClient selectHeaderContentType:@[@"application/json"]];

    // Authentication setting
    NSArray *authSettings = @[];

    id bodyParam = nil;
    NSMutableDictionary *formParams = [[NSMutableDictionary alloc] init];
    NSMutableDictionary *files = [[NSMutableDictionary alloc] init];
    
    
    

    
    return [self.apiClient requestWithCompletionBlock: resourcePath
                                               method: @"GET"
                                           pathParams: pathParams
                                          queryParams: queryParams
                                           formParams: formParams
                                                files: files
                                                 body: bodyParam
                                         headerParams: headerParams
                                         authSettings: authSettings
                                   requestContentType: requestContentType
                                  responseContentType: responseContentType
                                         responseType: @"ASPDrawingObjectsResponse*"
                                      completionBlock: ^(id data, NSError *error) {
                  
                  completionBlock((ASPDrawingObjectsResponse*)data, error);
              }
          ];
}

///
/// Read document drawing object common info by its index.
///
///  @param name The document name.
///
///  @param objectIndex The drawing object index.
///
///  @param storage The document storage.
///
///  @param folder The document folder full path.
///
///  @returns ASPDrawingObjectResponse*
///
-(NSNumber*) getDocumentDrawingObjectByIndexWithCompletionBlock: (NSString*) name
                                                    objectIndex: (NSNumber*) objectIndex
                                                        storage: (NSString*) storage
                                                         folder: (NSString*) folder

                                              completionHandler: (void (^)(ASPDrawingObjectResponse* output, NSError* error))completionBlock {
    
    
    
    // verify the required parameter 'name' is set
    if (name == nil) {
        [NSException raise:@"Invalid parameter" format:@"Missing the required parameter `name` when calling `getDocumentDrawingObjectByIndex`"];
    }
    
    // verify the required parameter 'objectIndex' is set
    if (objectIndex == nil) {
        [NSException raise:@"Invalid parameter" format:@"Missing the required parameter `objectIndex` when calling `getDocumentDrawingObjectByIndex`"];
    }
    
    
    NSMutableString* resourcePath = [NSMutableString stringWithFormat:@"/words/{name}/drawingObjects/{objectIndex}"];
    
    // remove format in URL if needed
    if ([resourcePath rangeOfString:@".{format}"].location != NSNotFound) {
        [resourcePath replaceCharactersInRange: [resourcePath rangeOfString:@".{format}"] withString:@".json"];
    }
    
    NSMutableDictionary *pathParams = [[NSMutableDictionary alloc] init];
    if (name != nil) {
        pathParams[@"name"] = name;
    }
    if (objectIndex != nil) {
        pathParams[@"objectIndex"] = objectIndex;
    }
    
    
    NSMutableDictionary* queryParams = [[NSMutableDictionary alloc] init];
    if(storage != nil) {
        
        queryParams[@"storage"] = storage;
    }
    if(folder != nil) {
        
        queryParams[@"folder"] = folder;
    }
    
    NSMutableDictionary* headerParams = [NSMutableDictionary dictionaryWithDictionary:self.defaultHeaders];
    
    
    
    // HTTP header `Accept`
    headerParams[@"Accept"] = [ASPApiClient selectHeaderAccept:@[@"application/json"]];
    if ([headerParams[@"Accept"] length] == 0) {
        [headerParams removeObjectForKey:@"Accept"];
    }
    
    // response content type
    NSString *responseContentType;
    if ([headerParams objectForKey:@"Accept"]) {
        responseContentType = [headerParams[@"Accept"] componentsSeparatedByString:@", "][0];
    }
    else {
        responseContentType = @"";
    }
    
    // request content type
    NSString *requestContentType = [ASPApiClient selectHeaderContentType:@[@"application/json"]];
    
    // Authentication setting
    NSArray *authSettings = @[];
    
    id bodyParam = nil;
    NSMutableDictionary *formParams = [[NSMutableDictionary alloc] init];
    NSMutableDictionary *files = [[NSMutableDictionary alloc] init];
    
    
    
    
    
    return [self.apiClient requestWithCompletionBlock: resourcePath
                                               method: @"GET"
                                           pathParams: pathParams
                                          queryParams: queryParams
                                           formParams: formParams
                                                files: files
                                                 body: bodyParam
                                         headerParams: headerParams
                                         authSettings: authSettings
                                   requestContentType: requestContentType
                                  responseContentType: responseContentType
                                         responseType: @"ASPDrawingObjectResponse*"
                                      completionBlock: ^(id data, NSError *error) {
                                          
                                          completionBlock((ASPDrawingObjectResponse*)data, error);
                                      }
            ];
}

///
/// 
/// 
///  @param name 
///
///  @param objectIndex 
///
///  @param format 
///
///  @param storage 
///
///  @param folder 
///
///  @returns NSURL*
///
-(NSNumber*) getDocumentDrawingObjectByIndexWithFormatWithCompletionBlock: (NSString*) name
         objectIndex: (NSNumber*) objectIndex
         format: (NSString*) format
         storage: (NSString*) storage
         folder: (NSString*) folder
        
        completionHandler: (void (^)(NSURL* output, NSError* error))completionBlock { 
        

    
    // verify the required parameter 'name' is set
    if (name == nil) {
        [NSException raise:@"Invalid parameter" format:@"Missing the required parameter `name` when calling `getDocumentDrawingObjectByIndexWithFormat`"];
    }
    
    // verify the required parameter 'objectIndex' is set
    if (objectIndex == nil) {
        [NSException raise:@"Invalid parameter" format:@"Missing the required parameter `objectIndex` when calling `getDocumentDrawingObjectByIndexWithFormat`"];
    }
    
    // verify the required parameter 'format' is set
    if (format == nil) {
        [NSException raise:@"Invalid parameter" format:@"Missing the required parameter `format` when calling `getDocumentDrawingObjectByIndexWithFormat`"];
    }
    

    NSMutableString* resourcePath = [NSMutableString stringWithFormat:@"/words/{name}/drawingObjects/{objectIndex}"];

    // remove format in URL if needed
    if ([resourcePath rangeOfString:@".{format}"].location != NSNotFound) {
        [resourcePath replaceCharactersInRange: [resourcePath rangeOfString:@".{format}"] withString:@".json"];
    }

    NSMutableDictionary *pathParams = [[NSMutableDictionary alloc] init];
    if (name != nil) {
        pathParams[@"name"] = name;
    }
    if (objectIndex != nil) {
        pathParams[@"objectIndex"] = objectIndex;
    }
    

    NSMutableDictionary* queryParams = [[NSMutableDictionary alloc] init];
    if(format != nil) {
        
        queryParams[@"format"] = format;
    }
    if(storage != nil) {
        
        queryParams[@"storage"] = storage;
    }
    if(folder != nil) {
        
        queryParams[@"folder"] = folder;
    }
    
    NSMutableDictionary* headerParams = [NSMutableDictionary dictionaryWithDictionary:self.defaultHeaders];

    

    // HTTP header `Accept`
    headerParams[@"Accept"] = [ASPApiClient selectHeaderAccept:@[]];
    if ([headerParams[@"Accept"] length] == 0) {
        [headerParams removeObjectForKey:@"Accept"];
    }

    // response content type
    NSString *responseContentType;
    if ([headerParams objectForKey:@"Accept"]) {
        responseContentType = [headerParams[@"Accept"] componentsSeparatedByString:@", "][0];
    }
    else {
        responseContentType = @"";
    }

    // request content type
    NSString *requestContentType = [ASPApiClient selectHeaderContentType:@[@"application/json"]];

    // Authentication setting
    NSArray *authSettings = @[];

    id bodyParam = nil;
    NSMutableDictionary *formParams = [[NSMutableDictionary alloc] init];
    NSMutableDictionary *files = [[NSMutableDictionary alloc] init];
    
    
    

    
    return [self.apiClient requestWithCompletionBlock: resourcePath
                                               method: @"GET"
                                           pathParams: pathParams
                                          queryParams: queryParams
                                           formParams: formParams
                                                files: files
                                                 body: bodyParam
                                         headerParams: headerParams
                                         authSettings: authSettings
                                   requestContentType: requestContentType
                                  responseContentType: responseContentType
                                         responseType: @"NSURL*"
                                      completionBlock: ^(id data, NSError *error) {
                  
                  completionBlock((NSURL*)data, error);
              }
          ];
}

///
/// Read drawing object image data.
/// 
///  @param name The document name.
///
///  @param objectIndex The drawing object index.
///
///  @param storage The document storage.
///
///  @param folder The document folder.
///
///  @returns NSURL*
///
-(NSNumber*) getDocumentDrawingObjectImageDataWithCompletionBlock: (NSString*) name
         objectIndex: (NSNumber*) objectIndex
         storage: (NSString*) storage
         folder: (NSString*) folder
        
        completionHandler: (void (^)(NSURL* output, NSError* error))completionBlock { 
        

    
    // verify the required parameter 'name' is set
    if (name == nil) {
        [NSException raise:@"Invalid parameter" format:@"Missing the required parameter `name` when calling `getDocumentDrawingObjectImageData`"];
    }
    
    // verify the required parameter 'objectIndex' is set
    if (objectIndex == nil) {
        [NSException raise:@"Invalid parameter" format:@"Missing the required parameter `objectIndex` when calling `getDocumentDrawingObjectImageData`"];
    }
    

    NSMutableString* resourcePath = [NSMutableString stringWithFormat:@"/words/{name}/drawingObjects/{objectIndex}/imageData"];

    // remove format in URL if needed
    if ([resourcePath rangeOfString:@".{format}"].location != NSNotFound) {
        [resourcePath replaceCharactersInRange: [resourcePath rangeOfString:@".{format}"] withString:@".json"];
    }

    NSMutableDictionary *pathParams = [[NSMutableDictionary alloc] init];
    if (name != nil) {
        pathParams[@"name"] = name;
    }
    if (objectIndex != nil) {
        pathParams[@"objectIndex"] = objectIndex;
    }
    

    NSMutableDictionary* queryParams = [[NSMutableDictionary alloc] init];
    if(storage != nil) {
        
        queryParams[@"storage"] = storage;
    }
    if(folder != nil) {
        
        queryParams[@"folder"] = folder;
    }
    
    NSMutableDictionary* headerParams = [NSMutableDictionary dictionaryWithDictionary:self.defaultHeaders];

    

    // HTTP header `Accept`
    headerParams[@"Accept"] = [ASPApiClient selectHeaderAccept:@[]];
    if ([headerParams[@"Accept"] length] == 0) {
        [headerParams removeObjectForKey:@"Accept"];
    }

    // response content type
    NSString *responseContentType;
    if ([headerParams objectForKey:@"Accept"]) {
        responseContentType = [headerParams[@"Accept"] componentsSeparatedByString:@", "][0];
    }
    else {
        responseContentType = @"";
    }

    // request content type
    NSString *requestContentType = [ASPApiClient selectHeaderContentType:@[@"application/json"]];

    // Authentication setting
    NSArray *authSettings = @[];

    id bodyParam = nil;
    NSMutableDictionary *formParams = [[NSMutableDictionary alloc] init];
    NSMutableDictionary *files = [[NSMutableDictionary alloc] init];
    
    
    

    
    return [self.apiClient requestWithCompletionBlock: resourcePath
                                               method: @"GET"
                                           pathParams: pathParams
                                          queryParams: queryParams
                                           formParams: formParams
                                                files: files
                                                 body: bodyParam
                                         headerParams: headerParams
                                         authSettings: authSettings
                                   requestContentType: requestContentType
                                  responseContentType: responseContentType
                                         responseType: @"NSURL*"
                                      completionBlock: ^(id data, NSError *error) {
                  
                  completionBlock((NSURL*)data, error);
              }
          ];
}

///
/// Get drawing object OLE data.
/// 
///  @param name The document name.
///
///  @param objectIndex The object index.
///
///  @param storage The document storage.
///
///  @param folder The document folder.
///
///  @returns NSURL*
///
-(NSNumber*) getDocumentDrawingObjectOleDataWithCompletionBlock: (NSString*) name
         objectIndex: (NSNumber*) objectIndex
         storage: (NSString*) storage
         folder: (NSString*) folder
        
        completionHandler: (void (^)(NSURL* output, NSError* error))completionBlock { 
        

    
    // verify the required parameter 'name' is set
    if (name == nil) {
        [NSException raise:@"Invalid parameter" format:@"Missing the required parameter `name` when calling `getDocumentDrawingObjectOleData`"];
    }
    
    // verify the required parameter 'objectIndex' is set
    if (objectIndex == nil) {
        [NSException raise:@"Invalid parameter" format:@"Missing the required parameter `objectIndex` when calling `getDocumentDrawingObjectOleData`"];
    }
    

    NSMutableString* resourcePath = [NSMutableString stringWithFormat:@"/words/{name}/drawingObjects/{objectIndex}/oleData"];

    // remove format in URL if needed
    if ([resourcePath rangeOfString:@".{format}"].location != NSNotFound) {
        [resourcePath replaceCharactersInRange: [resourcePath rangeOfString:@".{format}"] withString:@".json"];
    }

    NSMutableDictionary *pathParams = [[NSMutableDictionary alloc] init];
    if (name != nil) {
        pathParams[@"name"] = name;
    }
    if (objectIndex != nil) {
        pathParams[@"objectIndex"] = objectIndex;
    }
    

    NSMutableDictionary* queryParams = [[NSMutableDictionary alloc] init];
    if(storage != nil) {
        
        queryParams[@"storage"] = storage;
    }
    if(folder != nil) {
        
        queryParams[@"folder"] = folder;
    }
    
    NSMutableDictionary* headerParams = [NSMutableDictionary dictionaryWithDictionary:self.defaultHeaders];

    

    // HTTP header `Accept`
    headerParams[@"Accept"] = [ASPApiClient selectHeaderAccept:@[]];
    if ([headerParams[@"Accept"] length] == 0) {
        [headerParams removeObjectForKey:@"Accept"];
    }

    // response content type
    NSString *responseContentType;
    if ([headerParams objectForKey:@"Accept"]) {
        responseContentType = [headerParams[@"Accept"] componentsSeparatedByString:@", "][0];
    }
    else {
        responseContentType = @"";
    }

    // request content type
    NSString *requestContentType = [ASPApiClient selectHeaderContentType:@[@"application/json"]];

    // Authentication setting
    NSArray *authSettings = @[];

    id bodyParam = nil;
    NSMutableDictionary *formParams = [[NSMutableDictionary alloc] init];
    NSMutableDictionary *files = [[NSMutableDictionary alloc] init];
    
    
    

    
    return [self.apiClient requestWithCompletionBlock: resourcePath
                                               method: @"GET"
                                           pathParams: pathParams
                                          queryParams: queryParams
                                           formParams: formParams
                                                files: files
                                                 body: bodyParam
                                         headerParams: headerParams
                                         authSettings: authSettings
                                   requestContentType: requestContentType
                                  responseContentType: responseContentType
                                         responseType: @"NSURL*"
                                      completionBlock: ^(id data, NSError *error) {
                  
                  completionBlock((NSURL*)data, error);
              }
          ];
}

///
/// Execute document mail merge operation.
/// 
///  @param name The document name.
///
///  @param withRegions With regions flag.
///
///  @param file 
///
///  @param mailMergeDataFile Mail merge data.
///
///  @param cleanup Clean up options.
///
///  @param filename Result name of the document after the operation. If this parameter is omitted then result of the operation will be saved as the source document
///
///  @param storage The document storage.
///
///  @param folder The document folder.
///
///  @param useWholeParagraphAsRegion Gets or sets a value indicating whether paragraph with TableStart or TableEnd field should be fully included into mail merge region or particular range between TableStart and TableEnd fields. The default value is true.
///
///  @returns ASPDocumentResponse*
///
-(NSNumber*) postDocumentExecuteMailMergeWithCompletionBlock: (NSString*) name
         withRegions: (NSNumber*) withRegions
         file: (NSURL*) file
         mailMergeDataFile: (NSString*) mailMergeDataFile
         cleanup: (NSString*) cleanup
         filename: (NSString*) filename
         storage: (NSString*) storage
         folder: (NSString*) folder
         useWholeParagraphAsRegion: (NSNumber*) useWholeParagraphAsRegion
        
        completionHandler: (void (^)(ASPDocumentResponse* output, NSError* error))completionBlock { 
        

    
    // verify the required parameter 'name' is set
    if (name == nil) {
        [NSException raise:@"Invalid parameter" format:@"Missing the required parameter `name` when calling `postDocumentExecuteMailMerge`"];
    }
    
    // verify the required parameter 'withRegions' is set
    if (withRegions == nil) {
        [NSException raise:@"Invalid parameter" format:@"Missing the required parameter `withRegions` when calling `postDocumentExecuteMailMerge`"];
    }
    
    // verify the required parameter 'file' is set
    if (file == nil) {
        [NSException raise:@"Invalid parameter" format:@"Missing the required parameter `file` when calling `postDocumentExecuteMailMerge`"];
    }
    

    NSMutableString* resourcePath = [NSMutableString stringWithFormat:@"/words/{name}/executeMailMerge/{withRegions}"];

    // remove format in URL if needed
    if ([resourcePath rangeOfString:@".{format}"].location != NSNotFound) {
        [resourcePath replaceCharactersInRange: [resourcePath rangeOfString:@".{format}"] withString:@".json"];
    }

    NSMutableDictionary *pathParams = [[NSMutableDictionary alloc] init];
    if (name != nil) {
        pathParams[@"name"] = name;
    }
    if (withRegions != nil) {
        pathParams[@"withRegions"] = withRegions;
    }
    

    NSMutableDictionary* queryParams = [[NSMutableDictionary alloc] init];
    if(mailMergeDataFile != nil) {
        
        queryParams[@"mailMergeDataFile"] = mailMergeDataFile;
    }
    if(cleanup != nil) {
        
        queryParams[@"cleanup"] = cleanup;
    }
    if(filename != nil) {
        
        queryParams[@"filename"] = filename;
    }
    if(storage != nil) {
        
        queryParams[@"storage"] = storage;
    }
    if(folder != nil) {
        
        queryParams[@"folder"] = folder;
    }
    if(useWholeParagraphAsRegion != nil) {
        
        queryParams[@"useWholeParagraphAsRegion"] = useWholeParagraphAsRegion;
    }
    
    NSMutableDictionary* headerParams = [NSMutableDictionary dictionaryWithDictionary:self.defaultHeaders];

    

    // HTTP header `Accept`
    headerParams[@"Accept"] = [ASPApiClient selectHeaderAccept:@[@"application/json"]];
    if ([headerParams[@"Accept"] length] == 0) {
        [headerParams removeObjectForKey:@"Accept"];
    }

    // response content type
    NSString *responseContentType;
    if ([headerParams objectForKey:@"Accept"]) {
        responseContentType = [headerParams[@"Accept"] componentsSeparatedByString:@", "][0];
    }
    else {
        responseContentType = @"";
    }

    // request content type
    NSString *requestContentType = [ASPApiClient selectHeaderContentType:@[@"multipart/form-data"]];

    // Authentication setting
    NSArray *authSettings = @[];

    id bodyParam = nil;
    NSMutableDictionary *formParams = [[NSMutableDictionary alloc] init];
    NSMutableDictionary *files = [[NSMutableDictionary alloc] init];
    
    
    
    files[@"file"] = file;
    
    
    

    
    return [self.apiClient requestWithCompletionBlock: resourcePath
                                               method: @"POST"
                                           pathParams: pathParams
                                          queryParams: queryParams
                                           formParams: formParams
                                                files: files
                                                 body: bodyParam
                                         headerParams: headerParams
                                         authSettings: authSettings
                                   requestContentType: requestContentType
                                  responseContentType: responseContentType
                                         responseType: @"ASPDocumentResponse*"
                                      completionBlock: ^(id data, NSError *error) {
                  
                  completionBlock((ASPDocumentResponse*)data, error);
              }
          ];
}

///
/// Populate document template with data.
/// 
///  @param name The template document name.
///
///  @param file 
///
///  @param cleanup Clean up options.
///
///  @param filename Result name of the document after the operation. If this parameter is omitted then result of the operation will be saved as the source document
///
///  @param storage The document storage.
///
///  @param folder The document folder.
///
///  @param useWholeParagraphAsRegion Gets or sets a value indicating whether paragraph with TableStart or TableEnd field should be fully included into mail merge region or particular range between TableStart and TableEnd fields.  The default value is true.
///
///  @param withRegions Merge with regions or not. True by default
///
///  @returns ASPDocumentResponse*
///
-(NSNumber*) postExecuteTemplateWithCompletionBlock: (NSString*) name
         file: (NSURL*) file
         cleanup: (NSString*) cleanup
         filename: (NSString*) filename
         storage: (NSString*) storage
         folder: (NSString*) folder
         useWholeParagraphAsRegion: (NSNumber*) useWholeParagraphAsRegion
         withRegions: (NSNumber*) withRegions
        
        completionHandler: (void (^)(ASPDocumentResponse* output, NSError* error))completionBlock { 
        

    
    // verify the required parameter 'name' is set
    if (name == nil) {
        [NSException raise:@"Invalid parameter" format:@"Missing the required parameter `name` when calling `postExecuteTemplate`"];
    }
    
    // verify the required parameter 'file' is set
    if (file == nil) {
        [NSException raise:@"Invalid parameter" format:@"Missing the required parameter `file` when calling `postExecuteTemplate`"];
    }
    

    NSMutableString* resourcePath = [NSMutableString stringWithFormat:@"/words/{name}/executeTemplate"];

    // remove format in URL if needed
    if ([resourcePath rangeOfString:@".{format}"].location != NSNotFound) {
        [resourcePath replaceCharactersInRange: [resourcePath rangeOfString:@".{format}"] withString:@".json"];
    }

    NSMutableDictionary *pathParams = [[NSMutableDictionary alloc] init];
    if (name != nil) {
        pathParams[@"name"] = name;
    }
    

    NSMutableDictionary* queryParams = [[NSMutableDictionary alloc] init];
    if(cleanup != nil) {
        
        queryParams[@"cleanup"] = cleanup;
    }
    if(filename != nil) {
        
        queryParams[@"filename"] = filename;
    }
    if(storage != nil) {
        
        queryParams[@"storage"] = storage;
    }
    if(folder != nil) {
        
        queryParams[@"folder"] = folder;
    }
    if(useWholeParagraphAsRegion != nil) {
        
        queryParams[@"useWholeParagraphAsRegion"] = useWholeParagraphAsRegion;
    }
    if(withRegions != nil) {
        
        queryParams[@"withRegions"] = withRegions;
    }
    
    NSMutableDictionary* headerParams = [NSMutableDictionary dictionaryWithDictionary:self.defaultHeaders];

    

    // HTTP header `Accept`
    headerParams[@"Accept"] = [ASPApiClient selectHeaderAccept:@[@"application/json"]];
    if ([headerParams[@"Accept"] length] == 0) {
        [headerParams removeObjectForKey:@"Accept"];
    }

    // response content type
    NSString *responseContentType;
    if ([headerParams objectForKey:@"Accept"]) {
        responseContentType = [headerParams[@"Accept"] componentsSeparatedByString:@", "][0];
    }
    else {
        responseContentType = @"";
    }

    // request content type
    NSString *requestContentType = [ASPApiClient selectHeaderContentType:@[@"multipart/form-data"]];

    // Authentication setting
    NSArray *authSettings = @[];

    id bodyParam = nil;
    NSMutableDictionary *formParams = [[NSMutableDictionary alloc] init];
    NSMutableDictionary *files = [[NSMutableDictionary alloc] init];
    
    
    
    files[@"file"] = file;
    
    
    

    
    return [self.apiClient requestWithCompletionBlock: resourcePath
                                               method: @"POST"
                                           pathParams: pathParams
                                          queryParams: queryParams
                                           formParams: formParams
                                                files: files
                                                 body: bodyParam
                                         headerParams: headerParams
                                         authSettings: authSettings
                                   requestContentType: requestContentType
                                  responseContentType: responseContentType
                                         responseType: @"ASPDocumentResponse*"
                                      completionBlock: ^(id data, NSError *error) {
                  
                  completionBlock((ASPDocumentResponse*)data, error);
              }
          ];
}

///
/// Remove fields from document.
/// 
///  @param name The file name.
///
///  @param storage The document storage.
///
///  @param folder The document folder.
///
///  @returns ASPBaseResponse*
///
-(NSNumber*) deleteDocumentFieldsWithCompletionBlock: (NSString*) name
         storage: (NSString*) storage
         folder: (NSString*) folder
        
        completionHandler: (void (^)(ASPBaseResponse* output, NSError* error))completionBlock { 
        

    
    // verify the required parameter 'name' is set
    if (name == nil) {
        [NSException raise:@"Invalid parameter" format:@"Missing the required parameter `name` when calling `deleteDocumentFields`"];
    }
    

    NSMutableString* resourcePath = [NSMutableString stringWithFormat:@"/words/{name}/fields"];

    // remove format in URL if needed
    if ([resourcePath rangeOfString:@".{format}"].location != NSNotFound) {
        [resourcePath replaceCharactersInRange: [resourcePath rangeOfString:@".{format}"] withString:@".json"];
    }

    NSMutableDictionary *pathParams = [[NSMutableDictionary alloc] init];
    if (name != nil) {
        pathParams[@"name"] = name;
    }
    

    NSMutableDictionary* queryParams = [[NSMutableDictionary alloc] init];
    if(storage != nil) {
        
        queryParams[@"storage"] = storage;
    }
    if(folder != nil) {
        
        queryParams[@"folder"] = folder;
    }
    
    NSMutableDictionary* headerParams = [NSMutableDictionary dictionaryWithDictionary:self.defaultHeaders];

    

    // HTTP header `Accept`
    headerParams[@"Accept"] = [ASPApiClient selectHeaderAccept:@[@"application/json"]];
    if ([headerParams[@"Accept"] length] == 0) {
        [headerParams removeObjectForKey:@"Accept"];
    }

    // response content type
    NSString *responseContentType;
    if ([headerParams objectForKey:@"Accept"]) {
        responseContentType = [headerParams[@"Accept"] componentsSeparatedByString:@", "][0];
    }
    else {
        responseContentType = @"";
    }

    // request content type
    NSString *requestContentType = [ASPApiClient selectHeaderContentType:@[@"application/json"]];

    // Authentication setting
    NSArray *authSettings = @[];

    id bodyParam = nil;
    NSMutableDictionary *formParams = [[NSMutableDictionary alloc] init];
    NSMutableDictionary *files = [[NSMutableDictionary alloc] init];
    
    
    

    
    return [self.apiClient requestWithCompletionBlock: resourcePath
                                               method: @"DELETE"
                                           pathParams: pathParams
                                          queryParams: queryParams
                                           formParams: formParams
                                                files: files
                                                 body: bodyParam
                                         headerParams: headerParams
                                         authSettings: authSettings
                                   requestContentType: requestContentType
                                  responseContentType: responseContentType
                                         responseType: @"ASPBaseResponse*"
                                      completionBlock: ^(id data, NSError *error) {
                  
                  completionBlock((ASPBaseResponse*)data, error);
              }
          ];
}

///
/// Delete document headers and footers.
/// 
///  @param name The document name.
///
///  @param headersFootersTypes List of types of headers and footers.
///
///  @param filename Result name of the document after the operation. If this parameter is omitted then result of the operation will be saved as the source document.
///
///  @param storage The document storage.
///
///  @param folder The document folder.
///
///  @returns ASPBaseResponse*
///
-(NSNumber*) deleteHeadersFootersWithCompletionBlock: (NSString*) name
         headersFootersTypes: (NSString*) headersFootersTypes
         filename: (NSString*) filename
         storage: (NSString*) storage
         folder: (NSString*) folder
        
        completionHandler: (void (^)(ASPBaseResponse* output, NSError* error))completionBlock { 
        

    
    // verify the required parameter 'name' is set
    if (name == nil) {
        [NSException raise:@"Invalid parameter" format:@"Missing the required parameter `name` when calling `deleteHeadersFooters`"];
    }
    

    NSMutableString* resourcePath = [NSMutableString stringWithFormat:@"/words/{name}/headersfooters"];

    // remove format in URL if needed
    if ([resourcePath rangeOfString:@".{format}"].location != NSNotFound) {
        [resourcePath replaceCharactersInRange: [resourcePath rangeOfString:@".{format}"] withString:@".json"];
    }

    NSMutableDictionary *pathParams = [[NSMutableDictionary alloc] init];
    if (name != nil) {
        pathParams[@"name"] = name;
    }
    

    NSMutableDictionary* queryParams = [[NSMutableDictionary alloc] init];
    if(headersFootersTypes != nil) {
        
        queryParams[@"headersFootersTypes"] = headersFootersTypes;
    }
    if(filename != nil) {
        
        queryParams[@"filename"] = filename;
    }
    if(storage != nil) {
        
        queryParams[@"storage"] = storage;
    }
    if(folder != nil) {
        
        queryParams[@"folder"] = folder;
    }
    
    NSMutableDictionary* headerParams = [NSMutableDictionary dictionaryWithDictionary:self.defaultHeaders];

    

    // HTTP header `Accept`
    headerParams[@"Accept"] = [ASPApiClient selectHeaderAccept:@[@"application/json"]];
    if ([headerParams[@"Accept"] length] == 0) {
        [headerParams removeObjectForKey:@"Accept"];
    }

    // response content type
    NSString *responseContentType;
    if ([headerParams objectForKey:@"Accept"]) {
        responseContentType = [headerParams[@"Accept"] componentsSeparatedByString:@", "][0];
    }
    else {
        responseContentType = @"";
    }

    // request content type
    NSString *requestContentType = [ASPApiClient selectHeaderContentType:@[@"application/json"]];

    // Authentication setting
    NSArray *authSettings = @[];

    id bodyParam = nil;
    NSMutableDictionary *formParams = [[NSMutableDictionary alloc] init];
    NSMutableDictionary *files = [[NSMutableDictionary alloc] init];
    
    
    

    
    return [self.apiClient requestWithCompletionBlock: resourcePath
                                               method: @"DELETE"
                                           pathParams: pathParams
                                          queryParams: queryParams
                                           formParams: formParams
                                                files: files
                                                 body: bodyParam
                                         headerParams: headerParams
                                         authSettings: authSettings
                                   requestContentType: requestContentType
                                  responseContentType: responseContentType
                                         responseType: @"ASPBaseResponse*"
                                      completionBlock: ^(id data, NSError *error) {
                  
                  completionBlock((ASPBaseResponse*)data, error);
              }
          ];
}

///
/// Read document hyperlinks common info.
/// 
///  @param name The document name.
///
///  @param storage The document storage.
///
///  @param folder The document folder.
///
///  @returns ASPHyperlinksResponse*
///
-(NSNumber*) getDocumentHyperlinksWithCompletionBlock: (NSString*) name
         storage: (NSString*) storage
         folder: (NSString*) folder
        
        completionHandler: (void (^)(ASPHyperlinksResponse* output, NSError* error))completionBlock { 
        

    
    // verify the required parameter 'name' is set
    if (name == nil) {
        [NSException raise:@"Invalid parameter" format:@"Missing the required parameter `name` when calling `getDocumentHyperlinks`"];
    }
    

    NSMutableString* resourcePath = [NSMutableString stringWithFormat:@"/words/{name}/hyperlinks"];

    // remove format in URL if needed
    if ([resourcePath rangeOfString:@".{format}"].location != NSNotFound) {
        [resourcePath replaceCharactersInRange: [resourcePath rangeOfString:@".{format}"] withString:@".json"];
    }

    NSMutableDictionary *pathParams = [[NSMutableDictionary alloc] init];
    if (name != nil) {
        pathParams[@"name"] = name;
    }
    

    NSMutableDictionary* queryParams = [[NSMutableDictionary alloc] init];
    if(storage != nil) {
        
        queryParams[@"storage"] = storage;
    }
    if(folder != nil) {
        
        queryParams[@"folder"] = folder;
    }
    
    NSMutableDictionary* headerParams = [NSMutableDictionary dictionaryWithDictionary:self.defaultHeaders];

    

    // HTTP header `Accept`
    headerParams[@"Accept"] = [ASPApiClient selectHeaderAccept:@[@"application/json"]];
    if ([headerParams[@"Accept"] length] == 0) {
        [headerParams removeObjectForKey:@"Accept"];
    }

    // response content type
    NSString *responseContentType;
    if ([headerParams objectForKey:@"Accept"]) {
        responseContentType = [headerParams[@"Accept"] componentsSeparatedByString:@", "][0];
    }
    else {
        responseContentType = @"";
    }

    // request content type
    NSString *requestContentType = [ASPApiClient selectHeaderContentType:@[@"application/json"]];

    // Authentication setting
    NSArray *authSettings = @[];

    id bodyParam = nil;
    NSMutableDictionary *formParams = [[NSMutableDictionary alloc] init];
    NSMutableDictionary *files = [[NSMutableDictionary alloc] init];
    
    
    

    
    return [self.apiClient requestWithCompletionBlock: resourcePath
                                               method: @"GET"
                                           pathParams: pathParams
                                          queryParams: queryParams
                                           formParams: formParams
                                                files: files
                                                 body: bodyParam
                                         headerParams: headerParams
                                         authSettings: authSettings
                                   requestContentType: requestContentType
                                  responseContentType: responseContentType
                                         responseType: @"ASPHyperlinksResponse*"
                                      completionBlock: ^(id data, NSError *error) {
                  
                  completionBlock((ASPHyperlinksResponse*)data, error);
              }
          ];
}

///
/// Read document hyperlink by its index.
/// 
///  @param name The document name.
///
///  @param hyperlinkIndex The hyperlink index.
///
///  @param storage The document storage.
///
///  @param folder The document folder.
///
///  @returns ASPHyperlinkResponse*
///
-(NSNumber*) getDocumentHyperlinkByIndexWithCompletionBlock: (NSString*) name
         hyperlinkIndex: (NSNumber*) hyperlinkIndex
         storage: (NSString*) storage
         folder: (NSString*) folder
        
        completionHandler: (void (^)(ASPHyperlinkResponse* output, NSError* error))completionBlock { 
        

    
    // verify the required parameter 'name' is set
    if (name == nil) {
        [NSException raise:@"Invalid parameter" format:@"Missing the required parameter `name` when calling `getDocumentHyperlinkByIndex`"];
    }
    
    // verify the required parameter 'hyperlinkIndex' is set
    if (hyperlinkIndex == nil) {
        [NSException raise:@"Invalid parameter" format:@"Missing the required parameter `hyperlinkIndex` when calling `getDocumentHyperlinkByIndex`"];
    }
    

    NSMutableString* resourcePath = [NSMutableString stringWithFormat:@"/words/{name}/hyperlinks/{hyperlinkIndex}"];

    // remove format in URL if needed
    if ([resourcePath rangeOfString:@".{format}"].location != NSNotFound) {
        [resourcePath replaceCharactersInRange: [resourcePath rangeOfString:@".{format}"] withString:@".json"];
    }

    NSMutableDictionary *pathParams = [[NSMutableDictionary alloc] init];
    if (name != nil) {
        pathParams[@"name"] = name;
    }
    if (hyperlinkIndex != nil) {
        pathParams[@"hyperlinkIndex"] = hyperlinkIndex;
    }
    

    NSMutableDictionary* queryParams = [[NSMutableDictionary alloc] init];
    if(storage != nil) {
        
        queryParams[@"storage"] = storage;
    }
    if(folder != nil) {
        
        queryParams[@"folder"] = folder;
    }
    
    NSMutableDictionary* headerParams = [NSMutableDictionary dictionaryWithDictionary:self.defaultHeaders];

    

    // HTTP header `Accept`
    headerParams[@"Accept"] = [ASPApiClient selectHeaderAccept:@[@"application/json"]];
    if ([headerParams[@"Accept"] length] == 0) {
        [headerParams removeObjectForKey:@"Accept"];
    }

    // response content type
    NSString *responseContentType;
    if ([headerParams objectForKey:@"Accept"]) {
        responseContentType = [headerParams[@"Accept"] componentsSeparatedByString:@", "][0];
    }
    else {
        responseContentType = @"";
    }

    // request content type
    NSString *requestContentType = [ASPApiClient selectHeaderContentType:@[@"application/json"]];

    // Authentication setting
    NSArray *authSettings = @[];

    id bodyParam = nil;
    NSMutableDictionary *formParams = [[NSMutableDictionary alloc] init];
    NSMutableDictionary *files = [[NSMutableDictionary alloc] init];
    
    
    

    
    return [self.apiClient requestWithCompletionBlock: resourcePath
                                               method: @"GET"
                                           pathParams: pathParams
                                          queryParams: queryParams
                                           formParams: formParams
                                                files: files
                                                 body: bodyParam
                                         headerParams: headerParams
                                         authSettings: authSettings
                                   requestContentType: requestContentType
                                  responseContentType: responseContentType
                                         responseType: @"ASPHyperlinkResponse*"
                                      completionBlock: ^(id data, NSError *error) {
                  
                  completionBlock((ASPHyperlinkResponse*)data, error);
              }
          ];
}

///
/// Insert document page numbers.
/// 
///  @param name A document name.
///
///  @param pageNumber {PageNumber} with the page numbers settings.
///
///  @param filename Result name of the document after the operation. If this parameter is omitted then result of the operation will be saved as the source document
///
///  @param storage The document storage.
///
///  @param folder The document folder.
///
///  @returns ASPDocumentResponse*
///
-(NSNumber*) postInsertPageNumbersWithCompletionBlock: (NSString*) name
         pageNumber: (ASPPageNumber*) pageNumber
         filename: (NSString*) filename
         storage: (NSString*) storage
         folder: (NSString*) folder
        
        completionHandler: (void (^)(ASPDocumentResponse* output, NSError* error))completionBlock { 
        

    
    // verify the required parameter 'name' is set
    if (name == nil) {
        [NSException raise:@"Invalid parameter" format:@"Missing the required parameter `name` when calling `postInsertPageNumbers`"];
    }
    
    // verify the required parameter 'pageNumber' is set
    if (pageNumber == nil) {
        [NSException raise:@"Invalid parameter" format:@"Missing the required parameter `pageNumber` when calling `postInsertPageNumbers`"];
    }
    

    NSMutableString* resourcePath = [NSMutableString stringWithFormat:@"/words/{name}/insertPageNumbers"];

    // remove format in URL if needed
    if ([resourcePath rangeOfString:@".{format}"].location != NSNotFound) {
        [resourcePath replaceCharactersInRange: [resourcePath rangeOfString:@".{format}"] withString:@".json"];
    }

    NSMutableDictionary *pathParams = [[NSMutableDictionary alloc] init];
    if (name != nil) {
        pathParams[@"name"] = name;
    }
    

    NSMutableDictionary* queryParams = [[NSMutableDictionary alloc] init];
    if(filename != nil) {
        
        queryParams[@"filename"] = filename;
    }
    if(storage != nil) {
        
        queryParams[@"storage"] = storage;
    }
    if(folder != nil) {
        
        queryParams[@"folder"] = folder;
    }
    
    NSMutableDictionary* headerParams = [NSMutableDictionary dictionaryWithDictionary:self.defaultHeaders];

    

    // HTTP header `Accept`
    headerParams[@"Accept"] = [ASPApiClient selectHeaderAccept:@[@"application/json"]];
    if ([headerParams[@"Accept"] length] == 0) {
        [headerParams removeObjectForKey:@"Accept"];
    }

    // response content type
    NSString *responseContentType;
    if ([headerParams objectForKey:@"Accept"]) {
        responseContentType = [headerParams[@"Accept"] componentsSeparatedByString:@", "][0];
    }
    else {
        responseContentType = @"";
    }

    // request content type
    NSString *requestContentType = [ASPApiClient selectHeaderContentType:@[@"application/json"]];

    // Authentication setting
    NSArray *authSettings = @[];

    id bodyParam = nil;
    NSMutableDictionary *formParams = [[NSMutableDictionary alloc] init];
    NSMutableDictionary *files = [[NSMutableDictionary alloc] init];
    
    bodyParam = pageNumber;
    

    
    return [self.apiClient requestWithCompletionBlock: resourcePath
                                               method: @"POST"
                                           pathParams: pathParams
                                          queryParams: queryParams
                                           formParams: formParams
                                                files: files
                                                 body: bodyParam
                                         headerParams: headerParams
                                         authSettings: authSettings
                                   requestContentType: requestContentType
                                  responseContentType: responseContentType
                                         responseType: @"ASPDocumentResponse*"
                                      completionBlock: ^(id data, NSError *error) {
                  
                  completionBlock((ASPDocumentResponse*)data, error);
              }
          ];
}

///
/// Insert document watermark image.
/// 
///  @param name The document name.
///
///  @param filename Result name of the document after the operation. If this parameter is omitted then result of the operation will be saved as the source document
///
///  @param rotationAngle The watermark rotation angle.
///
///  @param image The image file server full name. If the name is empty the image is expected in request content.
///
///  @param storage The document storage.
///
///  @param folder The document folder.
///
///  @returns ASPDocumentResponse*
///
-(NSNumber*) postInsertWatermarkImageWithCompletionBlock: (NSString*) name
         filename: (NSString*) filename
         rotationAngle: (NSNumber*) rotationAngle
         image: (NSString*) image
         storage: (NSString*) storage
         folder: (NSString*) folder
        
        completionHandler: (void (^)(ASPDocumentResponse* output, NSError* error))completionBlock { 
        

    
    // verify the required parameter 'name' is set
    if (name == nil) {
        [NSException raise:@"Invalid parameter" format:@"Missing the required parameter `name` when calling `postInsertWatermarkImage`"];
    }
    

    NSMutableString* resourcePath = [NSMutableString stringWithFormat:@"/words/{name}/insertWatermarkImage"];

    // remove format in URL if needed
    if ([resourcePath rangeOfString:@".{format}"].location != NSNotFound) {
        [resourcePath replaceCharactersInRange: [resourcePath rangeOfString:@".{format}"] withString:@".json"];
    }

    NSMutableDictionary *pathParams = [[NSMutableDictionary alloc] init];
    if (name != nil) {
        pathParams[@"name"] = name;
    }
    

    NSMutableDictionary* queryParams = [[NSMutableDictionary alloc] init];
    if(filename != nil) {
        
        queryParams[@"filename"] = filename;
    }
    if(rotationAngle != nil) {
        
        queryParams[@"rotationAngle"] = rotationAngle;
    }
    if(image != nil) {
        
        queryParams[@"image"] = image;
    }
    if(storage != nil) {
        
        queryParams[@"storage"] = storage;
    }
    if(folder != nil) {
        
        queryParams[@"folder"] = folder;
    }
    
    NSMutableDictionary* headerParams = [NSMutableDictionary dictionaryWithDictionary:self.defaultHeaders];

    

    // HTTP header `Accept`
    headerParams[@"Accept"] = [ASPApiClient selectHeaderAccept:@[@"application/json"]];
    if ([headerParams[@"Accept"] length] == 0) {
        [headerParams removeObjectForKey:@"Accept"];
    }

    // response content type
    NSString *responseContentType;
    if ([headerParams objectForKey:@"Accept"]) {
        responseContentType = [headerParams[@"Accept"] componentsSeparatedByString:@", "][0];
    }
    else {
        responseContentType = @"";
    }

    // request content type
    NSString *requestContentType = [ASPApiClient selectHeaderContentType:@[@"application/json"]];

    // Authentication setting
    NSArray *authSettings = @[];

    id bodyParam = nil;
    NSMutableDictionary *formParams = [[NSMutableDictionary alloc] init];
    NSMutableDictionary *files = [[NSMutableDictionary alloc] init];
    
    
    

    
    return [self.apiClient requestWithCompletionBlock: resourcePath
                                               method: @"POST"
                                           pathParams: pathParams
                                          queryParams: queryParams
                                           formParams: formParams
                                                files: files
                                                 body: bodyParam
                                         headerParams: headerParams
                                         authSettings: authSettings
                                   requestContentType: requestContentType
                                  responseContentType: responseContentType
                                         responseType: @"ASPDocumentResponse*"
                                      completionBlock: ^(id data, NSError *error) {
                  
                  completionBlock((ASPDocumentResponse*)data, error);
              }
          ];
}

///
/// Insert document watermark text.
/// 
///  @param name The document name.
///
///  @param watermarkText {WatermarkText} with the watermark data.If the parameter is provided the query string parameters are ignored.
///
///  @param text The text to insert.
///
///  @param rotationAngle The text rotation angle.
///
///  @param filename Result name of the document after the operation. If this parameter is omitted then result of the operation will be saved as the source document
///
///  @param storage The document storage.
///
///  @param folder The document folder.
///
///  @returns ASPDocumentResponse*
///
-(NSNumber*) postInsertWatermarkTextWithCompletionBlock: (NSString*) name
         watermarkText: (ASPWatermarkText*) watermarkText
         text: (NSString*) text
         rotationAngle: (NSNumber*) rotationAngle
         filename: (NSString*) filename
         storage: (NSString*) storage
         folder: (NSString*) folder
        
        completionHandler: (void (^)(ASPDocumentResponse* output, NSError* error))completionBlock { 
        

    
    // verify the required parameter 'name' is set
    if (name == nil) {
        [NSException raise:@"Invalid parameter" format:@"Missing the required parameter `name` when calling `postInsertWatermarkText`"];
    }
    
    // verify the required parameter 'watermarkText' is set
    if (watermarkText == nil) {
        [NSException raise:@"Invalid parameter" format:@"Missing the required parameter `watermarkText` when calling `postInsertWatermarkText`"];
    }
    

    NSMutableString* resourcePath = [NSMutableString stringWithFormat:@"/words/{name}/insertWatermarkText"];

    // remove format in URL if needed
    if ([resourcePath rangeOfString:@".{format}"].location != NSNotFound) {
        [resourcePath replaceCharactersInRange: [resourcePath rangeOfString:@".{format}"] withString:@".json"];
    }

    NSMutableDictionary *pathParams = [[NSMutableDictionary alloc] init];
    if (name != nil) {
        pathParams[@"name"] = name;
    }
    

    NSMutableDictionary* queryParams = [[NSMutableDictionary alloc] init];
    if(text != nil) {
        
        queryParams[@"text"] = text;
    }
    if(rotationAngle != nil) {
        
        queryParams[@"rotationAngle"] = rotationAngle;
    }
    if(filename != nil) {
        
        queryParams[@"filename"] = filename;
    }
    if(storage != nil) {
        
        queryParams[@"storage"] = storage;
    }
    if(folder != nil) {
        
        queryParams[@"folder"] = folder;
    }
    
    NSMutableDictionary* headerParams = [NSMutableDictionary dictionaryWithDictionary:self.defaultHeaders];

    

    // HTTP header `Accept`
    headerParams[@"Accept"] = [ASPApiClient selectHeaderAccept:@[@"application/json"]];
    if ([headerParams[@"Accept"] length] == 0) {
        [headerParams removeObjectForKey:@"Accept"];
    }

    // response content type
    NSString *responseContentType;
    if ([headerParams objectForKey:@"Accept"]) {
        responseContentType = [headerParams[@"Accept"] componentsSeparatedByString:@", "][0];
    }
    else {
        responseContentType = @"";
    }

    // request content type
    NSString *requestContentType = [ASPApiClient selectHeaderContentType:@[@"application/json"]];

    // Authentication setting
    NSArray *authSettings = @[];

    id bodyParam = nil;
    NSMutableDictionary *formParams = [[NSMutableDictionary alloc] init];
    NSMutableDictionary *files = [[NSMutableDictionary alloc] init];
    
    bodyParam = watermarkText;
    

    
    return [self.apiClient requestWithCompletionBlock: resourcePath
                                               method: @"POST"
                                           pathParams: pathParams
                                          queryParams: queryParams
                                           formParams: formParams
                                                files: files
                                                 body: bodyParam
                                         headerParams: headerParams
                                         authSettings: authSettings
                                   requestContentType: requestContentType
                                  responseContentType: responseContentType
                                         responseType: @"ASPDocumentResponse*"
                                      completionBlock: ^(id data, NSError *error) {
                  
                  completionBlock((ASPDocumentResponse*)data, error);
              }
          ];
}

///
/// Remove macros from document.
/// 
///  @param name The file name.
///
///  @param storage The document storage.
///
///  @param folder The document folder.
///
///  @returns ASPBaseResponse*
///
-(NSNumber*) deleteDocumentMacrosWithCompletionBlock: (NSString*) name
         storage: (NSString*) storage
         folder: (NSString*) folder
        
        completionHandler: (void (^)(ASPBaseResponse* output, NSError* error))completionBlock { 
        

    
    // verify the required parameter 'name' is set
    if (name == nil) {
        [NSException raise:@"Invalid parameter" format:@"Missing the required parameter `name` when calling `deleteDocumentMacros`"];
    }
    

    NSMutableString* resourcePath = [NSMutableString stringWithFormat:@"/words/{name}/macros"];

    // remove format in URL if needed
    if ([resourcePath rangeOfString:@".{format}"].location != NSNotFound) {
        [resourcePath replaceCharactersInRange: [resourcePath rangeOfString:@".{format}"] withString:@".json"];
    }

    NSMutableDictionary *pathParams = [[NSMutableDictionary alloc] init];
    if (name != nil) {
        pathParams[@"name"] = name;
    }
    

    NSMutableDictionary* queryParams = [[NSMutableDictionary alloc] init];
    if(storage != nil) {
        
        queryParams[@"storage"] = storage;
    }
    if(folder != nil) {
        
        queryParams[@"folder"] = folder;
    }
    
    NSMutableDictionary* headerParams = [NSMutableDictionary dictionaryWithDictionary:self.defaultHeaders];

    

    // HTTP header `Accept`
    headerParams[@"Accept"] = [ASPApiClient selectHeaderAccept:@[@"application/json"]];
    if ([headerParams[@"Accept"] length] == 0) {
        [headerParams removeObjectForKey:@"Accept"];
    }

    // response content type
    NSString *responseContentType;
    if ([headerParams objectForKey:@"Accept"]) {
        responseContentType = [headerParams[@"Accept"] componentsSeparatedByString:@", "][0];
    }
    else {
        responseContentType = @"";
    }

    // request content type
    NSString *requestContentType = [ASPApiClient selectHeaderContentType:@[@"application/json"]];

    // Authentication setting
    NSArray *authSettings = @[];

    id bodyParam = nil;
    NSMutableDictionary *formParams = [[NSMutableDictionary alloc] init];
    NSMutableDictionary *files = [[NSMutableDictionary alloc] init];
    
    
    

    
    return [self.apiClient requestWithCompletionBlock: resourcePath
                                               method: @"DELETE"
                                           pathParams: pathParams
                                          queryParams: queryParams
                                           formParams: formParams
                                                files: files
                                                 body: bodyParam
                                         headerParams: headerParams
                                         authSettings: authSettings
                                   requestContentType: requestContentType
                                  responseContentType: responseContentType
                                         responseType: @"ASPBaseResponse*"
                                      completionBlock: ^(id data, NSError *error) {
                  
                  completionBlock((ASPBaseResponse*)data, error);
              }
          ];
}

///
/// Read document field names.
/// 
///  @param name The document name.
///
///  @param useNonMergeFields 
///
///  @param storage The document storage.
///
///  @param folder The document folder.
///
///  @returns ASPFieldNamesResponse*
///
-(NSNumber*) getDocumentFieldNamesWithCompletionBlock: (NSString*) name
         useNonMergeFields: (NSNumber*) useNonMergeFields
         storage: (NSString*) storage
         folder: (NSString*) folder
        
        completionHandler: (void (^)(ASPFieldNamesResponse* output, NSError* error))completionBlock { 
        

    
    // verify the required parameter 'name' is set
    if (name == nil) {
        [NSException raise:@"Invalid parameter" format:@"Missing the required parameter `name` when calling `getDocumentFieldNames`"];
    }
    

    NSMutableString* resourcePath = [NSMutableString stringWithFormat:@"/words/{name}/mailMergeFieldNames"];

    // remove format in URL if needed
    if ([resourcePath rangeOfString:@".{format}"].location != NSNotFound) {
        [resourcePath replaceCharactersInRange: [resourcePath rangeOfString:@".{format}"] withString:@".json"];
    }

    NSMutableDictionary *pathParams = [[NSMutableDictionary alloc] init];
    if (name != nil) {
        pathParams[@"name"] = name;
    }
    

    NSMutableDictionary* queryParams = [[NSMutableDictionary alloc] init];
    if(useNonMergeFields != nil) {
        
        queryParams[@"useNonMergeFields"] = useNonMergeFields;
    }
    if(storage != nil) {
        
        queryParams[@"storage"] = storage;
    }
    if(folder != nil) {
        
        queryParams[@"folder"] = folder;
    }
    
    NSMutableDictionary* headerParams = [NSMutableDictionary dictionaryWithDictionary:self.defaultHeaders];

    

    // HTTP header `Accept`
    headerParams[@"Accept"] = [ASPApiClient selectHeaderAccept:@[@"application/json"]];
    if ([headerParams[@"Accept"] length] == 0) {
        [headerParams removeObjectForKey:@"Accept"];
    }

    // response content type
    NSString *responseContentType;
    if ([headerParams objectForKey:@"Accept"]) {
        responseContentType = [headerParams[@"Accept"] componentsSeparatedByString:@", "][0];
    }
    else {
        responseContentType = @"";
    }

    // request content type
    NSString *requestContentType = [ASPApiClient selectHeaderContentType:@[@"application/json"]];

    // Authentication setting
    NSArray *authSettings = @[];

    id bodyParam = nil;
    NSMutableDictionary *formParams = [[NSMutableDictionary alloc] init];
    NSMutableDictionary *files = [[NSMutableDictionary alloc] init];
    
    
    

    
    return [self.apiClient requestWithCompletionBlock: resourcePath
                                               method: @"GET"
                                           pathParams: pathParams
                                          queryParams: queryParams
                                           formParams: formParams
                                                files: files
                                                 body: bodyParam
                                         headerParams: headerParams
                                         authSettings: authSettings
                                   requestContentType: requestContentType
                                  responseContentType: responseContentType
                                         responseType: @"ASPFieldNamesResponse*"
                                      completionBlock: ^(id data, NSError *error) {
                  
                  completionBlock((ASPFieldNamesResponse*)data, error);
              }
          ];
}

///
/// Return a list of paragraphs that are contained in the document.
/// 
///  @param name The document name.
///
///  @param storage The document storage.
///
///  @param folder The document folder.
///
///  @returns ASPParagraphLinkCollectionResponse*
///
-(NSNumber*) getDocumentParagraphsWithCompletionBlock: (NSString*) name
         storage: (NSString*) storage
         folder: (NSString*) folder
        
        completionHandler: (void (^)(ASPParagraphLinkCollectionResponse* output, NSError* error))completionBlock { 
        

    
    // verify the required parameter 'name' is set
    if (name == nil) {
        [NSException raise:@"Invalid parameter" format:@"Missing the required parameter `name` when calling `getDocumentParagraphs`"];
    }
    

    NSMutableString* resourcePath = [NSMutableString stringWithFormat:@"/words/{name}/paragraphs"];

    // remove format in URL if needed
    if ([resourcePath rangeOfString:@".{format}"].location != NSNotFound) {
        [resourcePath replaceCharactersInRange: [resourcePath rangeOfString:@".{format}"] withString:@".json"];
    }

    NSMutableDictionary *pathParams = [[NSMutableDictionary alloc] init];
    if (name != nil) {
        pathParams[@"name"] = name;
    }
    

    NSMutableDictionary* queryParams = [[NSMutableDictionary alloc] init];
    if(storage != nil) {
        
        queryParams[@"storage"] = storage;
    }
    if(folder != nil) {
        
        queryParams[@"folder"] = folder;
    }
    
    NSMutableDictionary* headerParams = [NSMutableDictionary dictionaryWithDictionary:self.defaultHeaders];

    

    // HTTP header `Accept`
    headerParams[@"Accept"] = [ASPApiClient selectHeaderAccept:@[@"application/json"]];
    if ([headerParams[@"Accept"] length] == 0) {
        [headerParams removeObjectForKey:@"Accept"];
    }

    // response content type
    NSString *responseContentType;
    if ([headerParams objectForKey:@"Accept"]) {
        responseContentType = [headerParams[@"Accept"] componentsSeparatedByString:@", "][0];
    }
    else {
        responseContentType = @"";
    }

    // request content type
    NSString *requestContentType = [ASPApiClient selectHeaderContentType:@[@"application/json"]];

    // Authentication setting
    NSArray *authSettings = @[];

    id bodyParam = nil;
    NSMutableDictionary *formParams = [[NSMutableDictionary alloc] init];
    NSMutableDictionary *files = [[NSMutableDictionary alloc] init];
    
    
    

    
    return [self.apiClient requestWithCompletionBlock: resourcePath
                                               method: @"GET"
                                           pathParams: pathParams
                                          queryParams: queryParams
                                           formParams: formParams
                                                files: files
                                                 body: bodyParam
                                         headerParams: headerParams
                                         authSettings: authSettings
                                   requestContentType: requestContentType
                                  responseContentType: responseContentType
                                         responseType: @"ASPParagraphLinkCollectionResponse*"
                                      completionBlock: ^(id data, NSError *error) {
                  
                  completionBlock((ASPParagraphLinkCollectionResponse*)data, error);
              }
          ];
}

///
/// This resource represents one of the paragraphs contained in the document.
/// 
///  @param name The document name.
///
///  @param index Paragraph index
///
///  @param storage The document storage.
///
///  @param folder The document folder.
///
///  @returns ASPParagraphResponse*
///
-(NSNumber*) getDocumentParagraphWithCompletionBlock: (NSString*) name
         index: (NSNumber*) index
         storage: (NSString*) storage
         folder: (NSString*) folder
        
        completionHandler: (void (^)(ASPParagraphResponse* output, NSError* error))completionBlock { 
        

    
    // verify the required parameter 'name' is set
    if (name == nil) {
        [NSException raise:@"Invalid parameter" format:@"Missing the required parameter `name` when calling `getDocumentParagraph`"];
    }
    
    // verify the required parameter 'index' is set
    if (index == nil) {
        [NSException raise:@"Invalid parameter" format:@"Missing the required parameter `index` when calling `getDocumentParagraph`"];
    }
    

    NSMutableString* resourcePath = [NSMutableString stringWithFormat:@"/words/{name}/paragraphs/{index}"];

    // remove format in URL if needed
    if ([resourcePath rangeOfString:@".{format}"].location != NSNotFound) {
        [resourcePath replaceCharactersInRange: [resourcePath rangeOfString:@".{format}"] withString:@".json"];
    }

    NSMutableDictionary *pathParams = [[NSMutableDictionary alloc] init];
    if (name != nil) {
        pathParams[@"name"] = name;
    }
    if (index != nil) {
        pathParams[@"index"] = index;
    }
    

    NSMutableDictionary* queryParams = [[NSMutableDictionary alloc] init];
    if(storage != nil) {
        
        queryParams[@"storage"] = storage;
    }
    if(folder != nil) {
        
        queryParams[@"folder"] = folder;
    }
    
    NSMutableDictionary* headerParams = [NSMutableDictionary dictionaryWithDictionary:self.defaultHeaders];

    

    // HTTP header `Accept`
    headerParams[@"Accept"] = [ASPApiClient selectHeaderAccept:@[@"application/json"]];
    if ([headerParams[@"Accept"] length] == 0) {
        [headerParams removeObjectForKey:@"Accept"];
    }

    // response content type
    NSString *responseContentType;
    if ([headerParams objectForKey:@"Accept"]) {
        responseContentType = [headerParams[@"Accept"] componentsSeparatedByString:@", "][0];
    }
    else {
        responseContentType = @"";
    }

    // request content type
    NSString *requestContentType = [ASPApiClient selectHeaderContentType:@[@"application/json"]];

    // Authentication setting
    NSArray *authSettings = @[];

    id bodyParam = nil;
    NSMutableDictionary *formParams = [[NSMutableDictionary alloc] init];
    NSMutableDictionary *files = [[NSMutableDictionary alloc] init];
    
    
    

    
    return [self.apiClient requestWithCompletionBlock: resourcePath
                                               method: @"GET"
                                           pathParams: pathParams
                                          queryParams: queryParams
                                           formParams: formParams
                                                files: files
                                                 body: bodyParam
                                         headerParams: headerParams
                                         authSettings: authSettings
                                   requestContentType: requestContentType
                                  responseContentType: responseContentType
                                         responseType: @"ASPParagraphResponse*"
                                      completionBlock: ^(id data, NSError *error) {
                  
                  completionBlock((ASPParagraphResponse*)data, error);
              }
          ];
}

///
/// Remove fields from paragraph.
/// 
///  @param name The file name.
///
///  @param index Paragraph index
///
///  @param storage The document storage.
///
///  @param folder The document folder.
///
///  @returns ASPBaseResponse*
///
-(NSNumber*) deleteParagraphFieldsWithCompletionBlock: (NSString*) name
         index: (NSNumber*) index
         storage: (NSString*) storage
         folder: (NSString*) folder
        
        completionHandler: (void (^)(ASPBaseResponse* output, NSError* error))completionBlock { 
        

    
    // verify the required parameter 'name' is set
    if (name == nil) {
        [NSException raise:@"Invalid parameter" format:@"Missing the required parameter `name` when calling `deleteParagraphFields`"];
    }
    
    // verify the required parameter 'index' is set
    if (index == nil) {
        [NSException raise:@"Invalid parameter" format:@"Missing the required parameter `index` when calling `deleteParagraphFields`"];
    }
    

    NSMutableString* resourcePath = [NSMutableString stringWithFormat:@"/words/{name}/paragraphs/{index}/fields"];

    // remove format in URL if needed
    if ([resourcePath rangeOfString:@".{format}"].location != NSNotFound) {
        [resourcePath replaceCharactersInRange: [resourcePath rangeOfString:@".{format}"] withString:@".json"];
    }

    NSMutableDictionary *pathParams = [[NSMutableDictionary alloc] init];
    if (name != nil) {
        pathParams[@"name"] = name;
    }
    if (index != nil) {
        pathParams[@"index"] = index;
    }
    

    NSMutableDictionary* queryParams = [[NSMutableDictionary alloc] init];
    if(storage != nil) {
        
        queryParams[@"storage"] = storage;
    }
    if(folder != nil) {
        
        queryParams[@"folder"] = folder;
    }
    
    NSMutableDictionary* headerParams = [NSMutableDictionary dictionaryWithDictionary:self.defaultHeaders];

    

    // HTTP header `Accept`
    headerParams[@"Accept"] = [ASPApiClient selectHeaderAccept:@[@"application/json"]];
    if ([headerParams[@"Accept"] length] == 0) {
        [headerParams removeObjectForKey:@"Accept"];
    }

    // response content type
    NSString *responseContentType;
    if ([headerParams objectForKey:@"Accept"]) {
        responseContentType = [headerParams[@"Accept"] componentsSeparatedByString:@", "][0];
    }
    else {
        responseContentType = @"";
    }

    // request content type
    NSString *requestContentType = [ASPApiClient selectHeaderContentType:@[@"application/json"]];

    // Authentication setting
    NSArray *authSettings = @[];

    id bodyParam = nil;
    NSMutableDictionary *formParams = [[NSMutableDictionary alloc] init];
    NSMutableDictionary *files = [[NSMutableDictionary alloc] init];
    
    
    

    
    return [self.apiClient requestWithCompletionBlock: resourcePath
                                               method: @"DELETE"
                                           pathParams: pathParams
                                          queryParams: queryParams
                                           formParams: formParams
                                                files: files
                                                 body: bodyParam
                                         headerParams: headerParams
                                         authSettings: authSettings
                                   requestContentType: requestContentType
                                  responseContentType: responseContentType
                                         responseType: @"ASPBaseResponse*"
                                      completionBlock: ^(id data, NSError *error) {
                  
                  completionBlock((ASPBaseResponse*)data, error);
              }
          ];
}

///
/// This resource represents one of the paragraphs contained in the document.
/// 
///  @param name The document name.
///
///  @param index Paragraph index
///
///  @param runIndex Run index
///
///  @param storage The document storage.
///
///  @param folder The document folder.
///
///  @returns ASPRunResponse*
///
-(NSNumber*) getDocumentParagraphRunWithCompletionBlock: (NSString*) name
         index: (NSNumber*) index
         runIndex: (NSNumber*) runIndex
         storage: (NSString*) storage
         folder: (NSString*) folder
        
        completionHandler: (void (^)(ASPRunResponse* output, NSError* error))completionBlock { 
        

    
    // verify the required parameter 'name' is set
    if (name == nil) {
        [NSException raise:@"Invalid parameter" format:@"Missing the required parameter `name` when calling `getDocumentParagraphRun`"];
    }
    
    // verify the required parameter 'index' is set
    if (index == nil) {
        [NSException raise:@"Invalid parameter" format:@"Missing the required parameter `index` when calling `getDocumentParagraphRun`"];
    }
    
    // verify the required parameter 'runIndex' is set
    if (runIndex == nil) {
        [NSException raise:@"Invalid parameter" format:@"Missing the required parameter `runIndex` when calling `getDocumentParagraphRun`"];
    }
    

    NSMutableString* resourcePath = [NSMutableString stringWithFormat:@"/words/{name}/paragraphs/{index}/runs/{runIndex}"];

    // remove format in URL if needed
    if ([resourcePath rangeOfString:@".{format}"].location != NSNotFound) {
        [resourcePath replaceCharactersInRange: [resourcePath rangeOfString:@".{format}"] withString:@".json"];
    }

    NSMutableDictionary *pathParams = [[NSMutableDictionary alloc] init];
    if (name != nil) {
        pathParams[@"name"] = name;
    }
    if (index != nil) {
        pathParams[@"index"] = index;
    }
    if (runIndex != nil) {
        pathParams[@"runIndex"] = runIndex;
    }
    

    NSMutableDictionary* queryParams = [[NSMutableDictionary alloc] init];
    if(storage != nil) {
        
        queryParams[@"storage"] = storage;
    }
    if(folder != nil) {
        
        queryParams[@"folder"] = folder;
    }
    
    NSMutableDictionary* headerParams = [NSMutableDictionary dictionaryWithDictionary:self.defaultHeaders];

    

    // HTTP header `Accept`
    headerParams[@"Accept"] = [ASPApiClient selectHeaderAccept:@[@"application/json"]];
    if ([headerParams[@"Accept"] length] == 0) {
        [headerParams removeObjectForKey:@"Accept"];
    }

    // response content type
    NSString *responseContentType;
    if ([headerParams objectForKey:@"Accept"]) {
        responseContentType = [headerParams[@"Accept"] componentsSeparatedByString:@", "][0];
    }
    else {
        responseContentType = @"";
    }

    // request content type
    NSString *requestContentType = [ASPApiClient selectHeaderContentType:@[@"application/json"]];

    // Authentication setting
    NSArray *authSettings = @[];

    id bodyParam = nil;
    NSMutableDictionary *formParams = [[NSMutableDictionary alloc] init];
    NSMutableDictionary *files = [[NSMutableDictionary alloc] init];
    
    
    

    
    return [self.apiClient requestWithCompletionBlock: resourcePath
                                               method: @"GET"
                                           pathParams: pathParams
                                          queryParams: queryParams
                                           formParams: formParams
                                                files: files
                                                 body: bodyParam
                                         headerParams: headerParams
                                         authSettings: authSettings
                                   requestContentType: requestContentType
                                  responseContentType: responseContentType
                                         responseType: @"ASPRunResponse*"
                                      completionBlock: ^(id data, NSError *error) {
                  
                  completionBlock((ASPRunResponse*)data, error);
              }
          ];
}

///
/// This resource represents one of the paragraphs contained in the document.
/// 
///  @param name The document name.
///
///  @param index Paragraph index
///
///  @param runIndex Run index
///
///  @param storage The document storage.
///
///  @param folder The document folder.
///
///  @returns ASPFontResponse*
///
-(NSNumber*) getDocumentParagraphRunFontWithCompletionBlock: (NSString*) name
         index: (NSNumber*) index
         runIndex: (NSNumber*) runIndex
         storage: (NSString*) storage
         folder: (NSString*) folder
        
        completionHandler: (void (^)(ASPFontResponse* output, NSError* error))completionBlock { 
        

    
    // verify the required parameter 'name' is set
    if (name == nil) {
        [NSException raise:@"Invalid parameter" format:@"Missing the required parameter `name` when calling `getDocumentParagraphRunFont`"];
    }
    
    // verify the required parameter 'index' is set
    if (index == nil) {
        [NSException raise:@"Invalid parameter" format:@"Missing the required parameter `index` when calling `getDocumentParagraphRunFont`"];
    }
    
    // verify the required parameter 'runIndex' is set
    if (runIndex == nil) {
        [NSException raise:@"Invalid parameter" format:@"Missing the required parameter `runIndex` when calling `getDocumentParagraphRunFont`"];
    }
    

    NSMutableString* resourcePath = [NSMutableString stringWithFormat:@"/words/{name}/paragraphs/{index}/runs/{runIndex}/font"];

    // remove format in URL if needed
    if ([resourcePath rangeOfString:@".{format}"].location != NSNotFound) {
        [resourcePath replaceCharactersInRange: [resourcePath rangeOfString:@".{format}"] withString:@".json"];
    }

    NSMutableDictionary *pathParams = [[NSMutableDictionary alloc] init];
    if (name != nil) {
        pathParams[@"name"] = name;
    }
    if (index != nil) {
        pathParams[@"index"] = index;
    }
    if (runIndex != nil) {
        pathParams[@"runIndex"] = runIndex;
    }
    

    NSMutableDictionary* queryParams = [[NSMutableDictionary alloc] init];
    if(storage != nil) {
        
        queryParams[@"storage"] = storage;
    }
    if(folder != nil) {
        
        queryParams[@"folder"] = folder;
    }
    
    NSMutableDictionary* headerParams = [NSMutableDictionary dictionaryWithDictionary:self.defaultHeaders];

    

    // HTTP header `Accept`
    headerParams[@"Accept"] = [ASPApiClient selectHeaderAccept:@[@"application/json"]];
    if ([headerParams[@"Accept"] length] == 0) {
        [headerParams removeObjectForKey:@"Accept"];
    }

    // response content type
    NSString *responseContentType;
    if ([headerParams objectForKey:@"Accept"]) {
        responseContentType = [headerParams[@"Accept"] componentsSeparatedByString:@", "][0];
    }
    else {
        responseContentType = @"";
    }

    // request content type
    NSString *requestContentType = [ASPApiClient selectHeaderContentType:@[@"application/json"]];

    // Authentication setting
    NSArray *authSettings = @[];

    id bodyParam = nil;
    NSMutableDictionary *formParams = [[NSMutableDictionary alloc] init];
    NSMutableDictionary *files = [[NSMutableDictionary alloc] init];
    
    
    

    
    return [self.apiClient requestWithCompletionBlock: resourcePath
                                               method: @"GET"
                                           pathParams: pathParams
                                          queryParams: queryParams
                                           formParams: formParams
                                                files: files
                                                 body: bodyParam
                                         headerParams: headerParams
                                         authSettings: authSettings
                                   requestContentType: requestContentType
                                  responseContentType: responseContentType
                                         responseType: @"ASPFontResponse*"
                                      completionBlock: ^(id data, NSError *error) {
                  
                  completionBlock((ASPFontResponse*)data, error);
              }
          ];
}

///
/// This resource represents one of the paragraphs contained in the document.
/// 
///  @param name The document name.
///
///  @param index Paragraph index
///
///  @param runIndex Run index
///
///  @param font Font object
///
///  @param storage The document storage.
///
///  @param folder The document folder.
///
///  @param filename Result name of the document after the operation. If this parameter is omitted then result of the operation will be saved as the source document
///
///  @returns ASPFontResponse*
///
-(NSNumber*) postDocumentParagraphRunFontWithCompletionBlock: (NSString*) name
         index: (NSNumber*) index
         runIndex: (NSNumber*) runIndex
         font: (ASPFont*) font
         storage: (NSString*) storage
         folder: (NSString*) folder
         filename: (NSString*) filename
        
        completionHandler: (void (^)(ASPFontResponse* output, NSError* error))completionBlock { 
        

    
    // verify the required parameter 'name' is set
    if (name == nil) {
        [NSException raise:@"Invalid parameter" format:@"Missing the required parameter `name` when calling `postDocumentParagraphRunFont`"];
    }
    
    // verify the required parameter 'index' is set
    if (index == nil) {
        [NSException raise:@"Invalid parameter" format:@"Missing the required parameter `index` when calling `postDocumentParagraphRunFont`"];
    }
    
    // verify the required parameter 'runIndex' is set
    if (runIndex == nil) {
        [NSException raise:@"Invalid parameter" format:@"Missing the required parameter `runIndex` when calling `postDocumentParagraphRunFont`"];
    }
    
    // verify the required parameter 'font' is set
    if (font == nil) {
        [NSException raise:@"Invalid parameter" format:@"Missing the required parameter `font` when calling `postDocumentParagraphRunFont`"];
    }
    

    NSMutableString* resourcePath = [NSMutableString stringWithFormat:@"/words/{name}/paragraphs/{index}/runs/{runIndex}/font"];

    // remove format in URL if needed
    if ([resourcePath rangeOfString:@".{format}"].location != NSNotFound) {
        [resourcePath replaceCharactersInRange: [resourcePath rangeOfString:@".{format}"] withString:@".json"];
    }

    NSMutableDictionary *pathParams = [[NSMutableDictionary alloc] init];
    if (name != nil) {
        pathParams[@"name"] = name;
    }
    if (index != nil) {
        pathParams[@"index"] = index;
    }
    if (runIndex != nil) {
        pathParams[@"runIndex"] = runIndex;
    }
    

    NSMutableDictionary* queryParams = [[NSMutableDictionary alloc] init];
    if(storage != nil) {
        
        queryParams[@"storage"] = storage;
    }
    if(folder != nil) {
        
        queryParams[@"folder"] = folder;
    }
    if(filename != nil) {
        
        queryParams[@"filename"] = filename;
    }
    
    NSMutableDictionary* headerParams = [NSMutableDictionary dictionaryWithDictionary:self.defaultHeaders];

    

    // HTTP header `Accept`
    headerParams[@"Accept"] = [ASPApiClient selectHeaderAccept:@[@"application/json"]];
    if ([headerParams[@"Accept"] length] == 0) {
        [headerParams removeObjectForKey:@"Accept"];
    }

    // response content type
    NSString *responseContentType;
    if ([headerParams objectForKey:@"Accept"]) {
        responseContentType = [headerParams[@"Accept"] componentsSeparatedByString:@", "][0];
    }
    else {
        responseContentType = @"";
    }

    // request content type
    NSString *requestContentType = [ASPApiClient selectHeaderContentType:@[@"application/json"]];

    // Authentication setting
    NSArray *authSettings = @[];

    id bodyParam = nil;
    NSMutableDictionary *formParams = [[NSMutableDictionary alloc] init];
    NSMutableDictionary *files = [[NSMutableDictionary alloc] init];
    
    bodyParam = font;
    

    
    return [self.apiClient requestWithCompletionBlock: resourcePath
                                               method: @"POST"
                                           pathParams: pathParams
                                          queryParams: queryParams
                                           formParams: formParams
                                                files: files
                                                 body: bodyParam
                                         headerParams: headerParams
                                         authSettings: authSettings
                                   requestContentType: requestContentType
                                  responseContentType: responseContentType
                                         responseType: @"ASPFontResponse*"
                                      completionBlock: ^(id data, NSError *error) {
                  
                  completionBlock((ASPFontResponse*)data, error);
              }
          ];
}

///
/// Read document protection common info.
/// 
///  @param name The document name.
///
///  @param storage The document storage.
///
///  @param folder The document folder.
///
///  @returns ASPProtectionDataResponse*
///
-(NSNumber*) getDocumentProtectionWithCompletionBlock: (NSString*) name
         storage: (NSString*) storage
         folder: (NSString*) folder
        
        completionHandler: (void (^)(ASPProtectionDataResponse* output, NSError* error))completionBlock { 
        

    
    // verify the required parameter 'name' is set
    if (name == nil) {
        [NSException raise:@"Invalid parameter" format:@"Missing the required parameter `name` when calling `getDocumentProtection`"];
    }
    

    NSMutableString* resourcePath = [NSMutableString stringWithFormat:@"/words/{name}/protection"];

    // remove format in URL if needed
    if ([resourcePath rangeOfString:@".{format}"].location != NSNotFound) {
        [resourcePath replaceCharactersInRange: [resourcePath rangeOfString:@".{format}"] withString:@".json"];
    }

    NSMutableDictionary *pathParams = [[NSMutableDictionary alloc] init];
    if (name != nil) {
        pathParams[@"name"] = name;
    }
    

    NSMutableDictionary* queryParams = [[NSMutableDictionary alloc] init];
    if(storage != nil) {
        
        queryParams[@"storage"] = storage;
    }
    if(folder != nil) {
        
        queryParams[@"folder"] = folder;
    }
    
    NSMutableDictionary* headerParams = [NSMutableDictionary dictionaryWithDictionary:self.defaultHeaders];

    

    // HTTP header `Accept`
    headerParams[@"Accept"] = [ASPApiClient selectHeaderAccept:@[@"application/json"]];
    if ([headerParams[@"Accept"] length] == 0) {
        [headerParams removeObjectForKey:@"Accept"];
    }

    // response content type
    NSString *responseContentType;
    if ([headerParams objectForKey:@"Accept"]) {
        responseContentType = [headerParams[@"Accept"] componentsSeparatedByString:@", "][0];
    }
    else {
        responseContentType = @"";
    }

    // request content type
    NSString *requestContentType = [ASPApiClient selectHeaderContentType:@[@"application/json"]];

    // Authentication setting
    NSArray *authSettings = @[];

    id bodyParam = nil;
    NSMutableDictionary *formParams = [[NSMutableDictionary alloc] init];
    NSMutableDictionary *files = [[NSMutableDictionary alloc] init];
    
    
    

    
    return [self.apiClient requestWithCompletionBlock: resourcePath
                                               method: @"GET"
                                           pathParams: pathParams
                                          queryParams: queryParams
                                           formParams: formParams
                                                files: files
                                                 body: bodyParam
                                         headerParams: headerParams
                                         authSettings: authSettings
                                   requestContentType: requestContentType
                                  responseContentType: responseContentType
                                         responseType: @"ASPProtectionDataResponse*"
                                      completionBlock: ^(id data, NSError *error) {
                  
                  completionBlock((ASPProtectionDataResponse*)data, error);
              }
          ];
}

///
/// Protect document.
/// 
///  @param name The document name.
///
///  @param protectionRequest {ProtectionRequest} with protection settings.
///
///  @param filename Result name of the document after the operation. If this parameter is omitted then result of the operation will be saved as the source document
///
///  @param storage The document storage.
///
///  @param folder The document folder.
///
///  @returns ASPProtectionDataResponse*
///
-(NSNumber*) putProtectDocumentWithCompletionBlock: (NSString*) name
         protectionRequest: (ASPProtectionRequest*) protectionRequest
         filename: (NSString*) filename
         storage: (NSString*) storage
         folder: (NSString*) folder
        
        completionHandler: (void (^)(ASPProtectionDataResponse* output, NSError* error))completionBlock { 
        

    
    // verify the required parameter 'name' is set
    if (name == nil) {
        [NSException raise:@"Invalid parameter" format:@"Missing the required parameter `name` when calling `putProtectDocument`"];
    }
    
    // verify the required parameter 'protectionRequest' is set
    if (protectionRequest == nil) {
        [NSException raise:@"Invalid parameter" format:@"Missing the required parameter `protectionRequest` when calling `putProtectDocument`"];
    }
    

    NSMutableString* resourcePath = [NSMutableString stringWithFormat:@"/words/{name}/protection"];

    // remove format in URL if needed
    if ([resourcePath rangeOfString:@".{format}"].location != NSNotFound) {
        [resourcePath replaceCharactersInRange: [resourcePath rangeOfString:@".{format}"] withString:@".json"];
    }

    NSMutableDictionary *pathParams = [[NSMutableDictionary alloc] init];
    if (name != nil) {
        pathParams[@"name"] = name;
    }
    

    NSMutableDictionary* queryParams = [[NSMutableDictionary alloc] init];
    if(filename != nil) {
        
        queryParams[@"filename"] = filename;
    }
    if(storage != nil) {
        
        queryParams[@"storage"] = storage;
    }
    if(folder != nil) {
        
        queryParams[@"folder"] = folder;
    }
    
    NSMutableDictionary* headerParams = [NSMutableDictionary dictionaryWithDictionary:self.defaultHeaders];

    

    // HTTP header `Accept`
    headerParams[@"Accept"] = [ASPApiClient selectHeaderAccept:@[@"application/json"]];
    if ([headerParams[@"Accept"] length] == 0) {
        [headerParams removeObjectForKey:@"Accept"];
    }

    // response content type
    NSString *responseContentType;
    if ([headerParams objectForKey:@"Accept"]) {
        responseContentType = [headerParams[@"Accept"] componentsSeparatedByString:@", "][0];
    }
    else {
        responseContentType = @"";
    }

    // request content type
    NSString *requestContentType = [ASPApiClient selectHeaderContentType:@[@"application/json"]];

    // Authentication setting
    NSArray *authSettings = @[];

    id bodyParam = nil;
    NSMutableDictionary *formParams = [[NSMutableDictionary alloc] init];
    NSMutableDictionary *files = [[NSMutableDictionary alloc] init];
    
    bodyParam = protectionRequest;
    

    
    return [self.apiClient requestWithCompletionBlock: resourcePath
                                               method: @"PUT"
                                           pathParams: pathParams
                                          queryParams: queryParams
                                           formParams: formParams
                                                files: files
                                                 body: bodyParam
                                         headerParams: headerParams
                                         authSettings: authSettings
                                   requestContentType: requestContentType
                                  responseContentType: responseContentType
                                         responseType: @"ASPProtectionDataResponse*"
                                      completionBlock: ^(id data, NSError *error) {
                  
                  completionBlock((ASPProtectionDataResponse*)data, error);
              }
          ];
}

///
/// Change document protection.
/// 
///  @param name The document name.
///
///  @param protectionRequest {ProtectionRequest} with protection settings.
///
///  @param filename Result name of the document after the operation. If this parameter is omitted then result of the operation will be saved as the source document
///
///  @param storage The document storage.
///
///  @param folder The document folder.
///
///  @returns ASPProtectionDataResponse*
///
-(NSNumber*) postChangeDocumentProtectionWithCompletionBlock: (NSString*) name
         protectionRequest: (ASPProtectionRequest*) protectionRequest
         filename: (NSString*) filename
         storage: (NSString*) storage
         folder: (NSString*) folder
        
        completionHandler: (void (^)(ASPProtectionDataResponse* output, NSError* error))completionBlock { 
        

    
    // verify the required parameter 'name' is set
    if (name == nil) {
        [NSException raise:@"Invalid parameter" format:@"Missing the required parameter `name` when calling `postChangeDocumentProtection`"];
    }
    
    // verify the required parameter 'protectionRequest' is set
    if (protectionRequest == nil) {
        [NSException raise:@"Invalid parameter" format:@"Missing the required parameter `protectionRequest` when calling `postChangeDocumentProtection`"];
    }
    

    NSMutableString* resourcePath = [NSMutableString stringWithFormat:@"/words/{name}/protection"];

    // remove format in URL if needed
    if ([resourcePath rangeOfString:@".{format}"].location != NSNotFound) {
        [resourcePath replaceCharactersInRange: [resourcePath rangeOfString:@".{format}"] withString:@".json"];
    }

    NSMutableDictionary *pathParams = [[NSMutableDictionary alloc] init];
    if (name != nil) {
        pathParams[@"name"] = name;
    }
    

    NSMutableDictionary* queryParams = [[NSMutableDictionary alloc] init];
    if(filename != nil) {
        
        queryParams[@"filename"] = filename;
    }
    if(storage != nil) {
        
        queryParams[@"storage"] = storage;
    }
    if(folder != nil) {
        
        queryParams[@"folder"] = folder;
    }
    
    NSMutableDictionary* headerParams = [NSMutableDictionary dictionaryWithDictionary:self.defaultHeaders];

    

    // HTTP header `Accept`
    headerParams[@"Accept"] = [ASPApiClient selectHeaderAccept:@[@"application/json"]];
    if ([headerParams[@"Accept"] length] == 0) {
        [headerParams removeObjectForKey:@"Accept"];
    }

    // response content type
    NSString *responseContentType;
    if ([headerParams objectForKey:@"Accept"]) {
        responseContentType = [headerParams[@"Accept"] componentsSeparatedByString:@", "][0];
    }
    else {
        responseContentType = @"";
    }

    // request content type
    NSString *requestContentType = [ASPApiClient selectHeaderContentType:@[@"application/json"]];

    // Authentication setting
    NSArray *authSettings = @[];

    id bodyParam = nil;
    NSMutableDictionary *formParams = [[NSMutableDictionary alloc] init];
    NSMutableDictionary *files = [[NSMutableDictionary alloc] init];
    
    bodyParam = protectionRequest;
    

    
    return [self.apiClient requestWithCompletionBlock: resourcePath
                                               method: @"POST"
                                           pathParams: pathParams
                                          queryParams: queryParams
                                           formParams: formParams
                                                files: files
                                                 body: bodyParam
                                         headerParams: headerParams
                                         authSettings: authSettings
                                   requestContentType: requestContentType
                                  responseContentType: responseContentType
                                         responseType: @"ASPProtectionDataResponse*"
                                      completionBlock: ^(id data, NSError *error) {
                  
                  completionBlock((ASPProtectionDataResponse*)data, error);
              }
          ];
}

///
/// Unprotect document.
/// 
///  @param name The document name.
///
///  @param protectionRequest {ProtectionRequest} with protection settings.
///
///  @param filename Result name of the document after the operation. If this parameter is omitted then result of the operation will be saved as the source document
///
///  @param storage The document storage.
///
///  @param folder The document folder.
///
///  @returns ASPProtectionDataResponse*
///
-(NSNumber*) deleteUnprotectDocumentWithCompletionBlock: (NSString*) name
         protectionRequest: (ASPProtectionRequest*) protectionRequest
         filename: (NSString*) filename
         storage: (NSString*) storage
         folder: (NSString*) folder
        
        completionHandler: (void (^)(ASPProtectionDataResponse* output, NSError* error))completionBlock { 
        

    
    // verify the required parameter 'name' is set
    if (name == nil) {
        [NSException raise:@"Invalid parameter" format:@"Missing the required parameter `name` when calling `deleteUnprotectDocument`"];
    }
    
    // verify the required parameter 'protectionRequest' is set
    if (protectionRequest == nil) {
        [NSException raise:@"Invalid parameter" format:@"Missing the required parameter `protectionRequest` when calling `deleteUnprotectDocument`"];
    }
    

    NSMutableString* resourcePath = [NSMutableString stringWithFormat:@"/words/{name}/protection"];

    // remove format in URL if needed
    if ([resourcePath rangeOfString:@".{format}"].location != NSNotFound) {
        [resourcePath replaceCharactersInRange: [resourcePath rangeOfString:@".{format}"] withString:@".json"];
    }

    NSMutableDictionary *pathParams = [[NSMutableDictionary alloc] init];
    if (name != nil) {
        pathParams[@"name"] = name;
    }
    

    NSMutableDictionary* queryParams = [[NSMutableDictionary alloc] init];
    if(filename != nil) {
        
        queryParams[@"filename"] = filename;
    }
    if(storage != nil) {
        
        queryParams[@"storage"] = storage;
    }
    if(folder != nil) {
        
        queryParams[@"folder"] = folder;
    }
    
    NSMutableDictionary* headerParams = [NSMutableDictionary dictionaryWithDictionary:self.defaultHeaders];

    

    // HTTP header `Accept`
    headerParams[@"Accept"] = [ASPApiClient selectHeaderAccept:@[@"application/json"]];
    if ([headerParams[@"Accept"] length] == 0) {
        [headerParams removeObjectForKey:@"Accept"];
    }

    // response content type
    NSString *responseContentType;
    if ([headerParams objectForKey:@"Accept"]) {
        responseContentType = [headerParams[@"Accept"] componentsSeparatedByString:@", "][0];
    }
    else {
        responseContentType = @"";
    }

    // request content type
    NSString *requestContentType = [ASPApiClient selectHeaderContentType:@[@"application/json"]];

    // Authentication setting
    NSArray *authSettings = @[];

    id bodyParam = nil;
    NSMutableDictionary *formParams = [[NSMutableDictionary alloc] init];
    NSMutableDictionary *files = [[NSMutableDictionary alloc] init];
    
    bodyParam = protectionRequest;
    

    
    return [self.apiClient requestWithCompletionBlock: resourcePath
                                               method: @"DELETE"
                                           pathParams: pathParams
                                          queryParams: queryParams
                                           formParams: formParams
                                                files: files
                                                 body: bodyParam
                                         headerParams: headerParams
                                         authSettings: authSettings
                                   requestContentType: requestContentType
                                  responseContentType: responseContentType
                                         responseType: @"ASPProtectionDataResponse*"
                                      completionBlock: ^(id data, NSError *error) {
                  
                  completionBlock((ASPProtectionDataResponse*)data, error);
              }
          ];
}

///
/// Replace document text.
/// 
///  @param name The document name.
///
///  @param replaceText {ReplaceTextResponse} with the replace operation settings.
///
///  @param filename Result name of the document after the operation. If this parameter is omitted then result of the operation will be saved as the source document
///
///  @param storage The document storage.
///
///  @param folder The document folder.
///
///  @returns ASPReplaceTextResponse*
///
-(NSNumber*) postReplaceTextWithCompletionBlock: (NSString*) name
         replaceText: (ASPReplaceTextRequest*) replaceText
         filename: (NSString*) filename
         storage: (NSString*) storage
         folder: (NSString*) folder
        
        completionHandler: (void (^)(ASPReplaceTextResponse* output, NSError* error))completionBlock { 
        

    
    // verify the required parameter 'name' is set
    if (name == nil) {
        [NSException raise:@"Invalid parameter" format:@"Missing the required parameter `name` when calling `postReplaceText`"];
    }
    
    // verify the required parameter 'replaceText' is set
    if (replaceText == nil) {
        [NSException raise:@"Invalid parameter" format:@"Missing the required parameter `replaceText` when calling `postReplaceText`"];
    }
    

    NSMutableString* resourcePath = [NSMutableString stringWithFormat:@"/words/{name}/replaceText"];

    // remove format in URL if needed
    if ([resourcePath rangeOfString:@".{format}"].location != NSNotFound) {
        [resourcePath replaceCharactersInRange: [resourcePath rangeOfString:@".{format}"] withString:@".json"];
    }

    NSMutableDictionary *pathParams = [[NSMutableDictionary alloc] init];
    if (name != nil) {
        pathParams[@"name"] = name;
    }
    

    NSMutableDictionary* queryParams = [[NSMutableDictionary alloc] init];
    if(filename != nil) {
        
        queryParams[@"filename"] = filename;
    }
    if(storage != nil) {
        
        queryParams[@"storage"] = storage;
    }
    if(folder != nil) {
        
        queryParams[@"folder"] = folder;
    }
    
    NSMutableDictionary* headerParams = [NSMutableDictionary dictionaryWithDictionary:self.defaultHeaders];

    

    // HTTP header `Accept`
    headerParams[@"Accept"] = [ASPApiClient selectHeaderAccept:@[@"application/json"]];
    if ([headerParams[@"Accept"] length] == 0) {
        [headerParams removeObjectForKey:@"Accept"];
    }

    // response content type
    NSString *responseContentType;
    if ([headerParams objectForKey:@"Accept"]) {
        responseContentType = [headerParams[@"Accept"] componentsSeparatedByString:@", "][0];
    }
    else {
        responseContentType = @"";
    }

    // request content type
    NSString *requestContentType = [ASPApiClient selectHeaderContentType:@[@"application/json"]];

    // Authentication setting
    NSArray *authSettings = @[];

    id bodyParam = nil;
    NSMutableDictionary *formParams = [[NSMutableDictionary alloc] init];
    NSMutableDictionary *files = [[NSMutableDictionary alloc] init];
    
    bodyParam = replaceText;
    

    
    return [self.apiClient requestWithCompletionBlock: resourcePath
                                               method: @"POST"
                                           pathParams: pathParams
                                          queryParams: queryParams
                                           formParams: formParams
                                                files: files
                                                 body: bodyParam
                                         headerParams: headerParams
                                         authSettings: authSettings
                                   requestContentType: requestContentType
                                  responseContentType: responseContentType
                                         responseType: @"ASPReplaceTextResponse*"
                                      completionBlock: ^(id data, NSError *error) {
                  
                  completionBlock((ASPReplaceTextResponse*)data, error);
              }
          ];
}

///
/// Accept all revisions in document
/// 
///  @param name The document name.
///
///  @param filename Result name of the document after the operation. If this parameter is omitted then result of the operation will be saved as the source document.
///
///  @param storage The document storage.
///
///  @param folder The document folder.
///
///  @returns ASPRevisionsModificationResponse*
///
-(NSNumber*) acceptAllRevisionsWithCompletionBlock: (NSString*) name
         filename: (NSString*) filename
         storage: (NSString*) storage
         folder: (NSString*) folder
        
        completionHandler: (void (^)(ASPRevisionsModificationResponse* output, NSError* error))completionBlock { 
        

    
    // verify the required parameter 'name' is set
    if (name == nil) {
        [NSException raise:@"Invalid parameter" format:@"Missing the required parameter `name` when calling `acceptAllRevisions`"];
    }
    

    NSMutableString* resourcePath = [NSMutableString stringWithFormat:@"/words/{name}/revisions/acceptAll"];

    // remove format in URL if needed
    if ([resourcePath rangeOfString:@".{format}"].location != NSNotFound) {
        [resourcePath replaceCharactersInRange: [resourcePath rangeOfString:@".{format}"] withString:@".json"];
    }

    NSMutableDictionary *pathParams = [[NSMutableDictionary alloc] init];
    if (name != nil) {
        pathParams[@"name"] = name;
    }
    

    NSMutableDictionary* queryParams = [[NSMutableDictionary alloc] init];
    if(filename != nil) {
        
        queryParams[@"filename"] = filename;
    }
    if(storage != nil) {
        
        queryParams[@"storage"] = storage;
    }
    if(folder != nil) {
        
        queryParams[@"folder"] = folder;
    }
    
    NSMutableDictionary* headerParams = [NSMutableDictionary dictionaryWithDictionary:self.defaultHeaders];

    

    // HTTP header `Accept`
    headerParams[@"Accept"] = [ASPApiClient selectHeaderAccept:@[@"application/json"]];
    if ([headerParams[@"Accept"] length] == 0) {
        [headerParams removeObjectForKey:@"Accept"];
    }

    // response content type
    NSString *responseContentType;
    if ([headerParams objectForKey:@"Accept"]) {
        responseContentType = [headerParams[@"Accept"] componentsSeparatedByString:@", "][0];
    }
    else {
        responseContentType = @"";
    }

    // request content type
    NSString *requestContentType = [ASPApiClient selectHeaderContentType:@[@"application/json"]];

    // Authentication setting
    NSArray *authSettings = @[];

    id bodyParam = nil;
    NSMutableDictionary *formParams = [[NSMutableDictionary alloc] init];
    NSMutableDictionary *files = [[NSMutableDictionary alloc] init];
    
    
    

    
    return [self.apiClient requestWithCompletionBlock: resourcePath
                                               method: @"POST"
                                           pathParams: pathParams
                                          queryParams: queryParams
                                           formParams: formParams
                                                files: files
                                                 body: bodyParam
                                         headerParams: headerParams
                                         authSettings: authSettings
                                   requestContentType: requestContentType
                                  responseContentType: responseContentType
                                         responseType: @"ASPRevisionsModificationResponse*"
                                      completionBlock: ^(id data, NSError *error) {
                  
                  completionBlock((ASPRevisionsModificationResponse*)data, error);
              }
          ];
}

///
/// Reject all revisions in document
/// 
///  @param name The document name.
///
///  @param filename Result name of the document after the operation. If this parameter is omitted then result of the operation will be saved as the source document.
///
///  @param storage The document storage.
///
///  @param folder The document folder.
///
///  @returns ASPRevisionsModificationResponse*
///
-(NSNumber*) rejectAllRevisionsWithCompletionBlock: (NSString*) name
         filename: (NSString*) filename
         storage: (NSString*) storage
         folder: (NSString*) folder
        
        completionHandler: (void (^)(ASPRevisionsModificationResponse* output, NSError* error))completionBlock { 
        

    
    // verify the required parameter 'name' is set
    if (name == nil) {
        [NSException raise:@"Invalid parameter" format:@"Missing the required parameter `name` when calling `rejectAllRevisions`"];
    }
    

    NSMutableString* resourcePath = [NSMutableString stringWithFormat:@"/words/{name}/revisions/rejectAll"];

    // remove format in URL if needed
    if ([resourcePath rangeOfString:@".{format}"].location != NSNotFound) {
        [resourcePath replaceCharactersInRange: [resourcePath rangeOfString:@".{format}"] withString:@".json"];
    }

    NSMutableDictionary *pathParams = [[NSMutableDictionary alloc] init];
    if (name != nil) {
        pathParams[@"name"] = name;
    }
    

    NSMutableDictionary* queryParams = [[NSMutableDictionary alloc] init];
    if(filename != nil) {
        
        queryParams[@"filename"] = filename;
    }
    if(storage != nil) {
        
        queryParams[@"storage"] = storage;
    }
    if(folder != nil) {
        
        queryParams[@"folder"] = folder;
    }
    
    NSMutableDictionary* headerParams = [NSMutableDictionary dictionaryWithDictionary:self.defaultHeaders];

    

    // HTTP header `Accept`
    headerParams[@"Accept"] = [ASPApiClient selectHeaderAccept:@[@"application/json"]];
    if ([headerParams[@"Accept"] length] == 0) {
        [headerParams removeObjectForKey:@"Accept"];
    }

    // response content type
    NSString *responseContentType;
    if ([headerParams objectForKey:@"Accept"]) {
        responseContentType = [headerParams[@"Accept"] componentsSeparatedByString:@", "][0];
    }
    else {
        responseContentType = @"";
    }

    // request content type
    NSString *requestContentType = [ASPApiClient selectHeaderContentType:@[@"application/json"]];

    // Authentication setting
    NSArray *authSettings = @[];

    id bodyParam = nil;
    NSMutableDictionary *formParams = [[NSMutableDictionary alloc] init];
    NSMutableDictionary *files = [[NSMutableDictionary alloc] init];
    
    
    

    
    return [self.apiClient requestWithCompletionBlock: resourcePath
                                               method: @"POST"
                                           pathParams: pathParams
                                          queryParams: queryParams
                                           formParams: formParams
                                                files: files
                                                 body: bodyParam
                                         headerParams: headerParams
                                         authSettings: authSettings
                                   requestContentType: requestContentType
                                  responseContentType: responseContentType
                                         responseType: @"ASPRevisionsModificationResponse*"
                                      completionBlock: ^(id data, NSError *error) {
                  
                  completionBlock((ASPRevisionsModificationResponse*)data, error);
              }
          ];
}

///
/// 
/// 
///  @param name 
///
///  @param pattern 
///
///  @param storage 
///
///  @param folder 
///
///  @returns ASPSearchResponse*
///
-(NSNumber*) getWordsSearchWithCompletionBlock: (NSString*) name
         pattern: (NSString*) pattern
         storage: (NSString*) storage
         folder: (NSString*) folder
        
        completionHandler: (void (^)(ASPSearchResponse* output, NSError* error))completionBlock { 
        

    
    // verify the required parameter 'name' is set
    if (name == nil) {
        [NSException raise:@"Invalid parameter" format:@"Missing the required parameter `name` when calling `getWordsSearch`"];
    }
    
    // verify the required parameter 'pattern' is set
    if (pattern == nil) {
        [NSException raise:@"Invalid parameter" format:@"Missing the required parameter `pattern` when calling `getWordsSearch`"];
    }
    

    NSMutableString* resourcePath = [NSMutableString stringWithFormat:@"/words/{name}/search"];

    // remove format in URL if needed
    if ([resourcePath rangeOfString:@".{format}"].location != NSNotFound) {
        [resourcePath replaceCharactersInRange: [resourcePath rangeOfString:@".{format}"] withString:@".json"];
    }

    NSMutableDictionary *pathParams = [[NSMutableDictionary alloc] init];
    if (name != nil) {
        pathParams[@"name"] = name;
    }
    

    NSMutableDictionary* queryParams = [[NSMutableDictionary alloc] init];
    if(pattern != nil) {
        
        queryParams[@"pattern"] = pattern;
    }
    if(storage != nil) {
        
        queryParams[@"storage"] = storage;
    }
    if(folder != nil) {
        
        queryParams[@"folder"] = folder;
    }
    
    NSMutableDictionary* headerParams = [NSMutableDictionary dictionaryWithDictionary:self.defaultHeaders];

    

    // HTTP header `Accept`
    headerParams[@"Accept"] = [ASPApiClient selectHeaderAccept:@[@"application/json"]];
    if ([headerParams[@"Accept"] length] == 0) {
        [headerParams removeObjectForKey:@"Accept"];
    }

    // response content type
    NSString *responseContentType;
    if ([headerParams objectForKey:@"Accept"]) {
        responseContentType = [headerParams[@"Accept"] componentsSeparatedByString:@", "][0];
    }
    else {
        responseContentType = @"";
    }

    // request content type
    NSString *requestContentType = [ASPApiClient selectHeaderContentType:@[@"application/json"]];

    // Authentication setting
    NSArray *authSettings = @[];

    id bodyParam = nil;
    NSMutableDictionary *formParams = [[NSMutableDictionary alloc] init];
    NSMutableDictionary *files = [[NSMutableDictionary alloc] init];
    
    
    

    
    return [self.apiClient requestWithCompletionBlock: resourcePath
                                               method: @"GET"
                                           pathParams: pathParams
                                          queryParams: queryParams
                                           formParams: formParams
                                                files: files
                                                 body: bodyParam
                                         headerParams: headerParams
                                         authSettings: authSettings
                                   requestContentType: requestContentType
                                  responseContentType: responseContentType
                                         responseType: @"ASPSearchResponse*"
                                      completionBlock: ^(id data, NSError *error) {
                  
                  completionBlock((ASPSearchResponse*)data, error);
              }
          ];
}

///
/// Return a list of sections that are contained in the document.
/// 
///  @param name The document name.
///
///  @param storage The document storage.
///
///  @param folder The document folder.
///
///  @returns ASPSectionLinkCollectionResponse*
///
-(NSNumber*) getSectionsWithCompletionBlock: (NSString*) name
         storage: (NSString*) storage
         folder: (NSString*) folder
        
        completionHandler: (void (^)(ASPSectionLinkCollectionResponse* output, NSError* error))completionBlock { 
        

    
    // verify the required parameter 'name' is set
    if (name == nil) {
        [NSException raise:@"Invalid parameter" format:@"Missing the required parameter `name` when calling `getSections`"];
    }
    

    NSMutableString* resourcePath = [NSMutableString stringWithFormat:@"/words/{name}/sections"];

    // remove format in URL if needed
    if ([resourcePath rangeOfString:@".{format}"].location != NSNotFound) {
        [resourcePath replaceCharactersInRange: [resourcePath rangeOfString:@".{format}"] withString:@".json"];
    }

    NSMutableDictionary *pathParams = [[NSMutableDictionary alloc] init];
    if (name != nil) {
        pathParams[@"name"] = name;
    }
    

    NSMutableDictionary* queryParams = [[NSMutableDictionary alloc] init];
    if(storage != nil) {
        
        queryParams[@"storage"] = storage;
    }
    if(folder != nil) {
        
        queryParams[@"folder"] = folder;
    }
    
    NSMutableDictionary* headerParams = [NSMutableDictionary dictionaryWithDictionary:self.defaultHeaders];

    

    // HTTP header `Accept`
    headerParams[@"Accept"] = [ASPApiClient selectHeaderAccept:@[@"application/json"]];
    if ([headerParams[@"Accept"] length] == 0) {
        [headerParams removeObjectForKey:@"Accept"];
    }

    // response content type
    NSString *responseContentType;
    if ([headerParams objectForKey:@"Accept"]) {
        responseContentType = [headerParams[@"Accept"] componentsSeparatedByString:@", "][0];
    }
    else {
        responseContentType = @"";
    }

    // request content type
    NSString *requestContentType = [ASPApiClient selectHeaderContentType:@[@"application/json"]];

    // Authentication setting
    NSArray *authSettings = @[];

    id bodyParam = nil;
    NSMutableDictionary *formParams = [[NSMutableDictionary alloc] init];
    NSMutableDictionary *files = [[NSMutableDictionary alloc] init];
    
    
    

    
    return [self.apiClient requestWithCompletionBlock: resourcePath
                                               method: @"GET"
                                           pathParams: pathParams
                                          queryParams: queryParams
                                           formParams: formParams
                                                files: files
                                                 body: bodyParam
                                         headerParams: headerParams
                                         authSettings: authSettings
                                   requestContentType: requestContentType
                                  responseContentType: responseContentType
                                         responseType: @"ASPSectionLinkCollectionResponse*"
                                      completionBlock: ^(id data, NSError *error) {
                  
                  completionBlock((ASPSectionLinkCollectionResponse*)data, error);
              }
          ];
}

///
/// Get document section by index.
/// 
///  @param name The document name.
///
///  @param sectionIndex Section index
///
///  @param storage The document storage.
///
///  @param folder The document folder.
///
///  @returns ASPSectionResponse*
///
-(NSNumber*) getSectionWithCompletionBlock: (NSString*) name
         sectionIndex: (NSNumber*) sectionIndex
         storage: (NSString*) storage
         folder: (NSString*) folder
        
        completionHandler: (void (^)(ASPSectionResponse* output, NSError* error))completionBlock { 
        

    
    // verify the required parameter 'name' is set
    if (name == nil) {
        [NSException raise:@"Invalid parameter" format:@"Missing the required parameter `name` when calling `getSection`"];
    }
    
    // verify the required parameter 'sectionIndex' is set
    if (sectionIndex == nil) {
        [NSException raise:@"Invalid parameter" format:@"Missing the required parameter `sectionIndex` when calling `getSection`"];
    }
    

    NSMutableString* resourcePath = [NSMutableString stringWithFormat:@"/words/{name}/sections/{sectionIndex}"];

    // remove format in URL if needed
    if ([resourcePath rangeOfString:@".{format}"].location != NSNotFound) {
        [resourcePath replaceCharactersInRange: [resourcePath rangeOfString:@".{format}"] withString:@".json"];
    }

    NSMutableDictionary *pathParams = [[NSMutableDictionary alloc] init];
    if (name != nil) {
        pathParams[@"name"] = name;
    }
    if (sectionIndex != nil) {
        pathParams[@"sectionIndex"] = sectionIndex;
    }
    

    NSMutableDictionary* queryParams = [[NSMutableDictionary alloc] init];
    if(storage != nil) {
        
        queryParams[@"storage"] = storage;
    }
    if(folder != nil) {
        
        queryParams[@"folder"] = folder;
    }
    
    NSMutableDictionary* headerParams = [NSMutableDictionary dictionaryWithDictionary:self.defaultHeaders];

    

    // HTTP header `Accept`
    headerParams[@"Accept"] = [ASPApiClient selectHeaderAccept:@[@"application/json"]];
    if ([headerParams[@"Accept"] length] == 0) {
        [headerParams removeObjectForKey:@"Accept"];
    }

    // response content type
    NSString *responseContentType;
    if ([headerParams objectForKey:@"Accept"]) {
        responseContentType = [headerParams[@"Accept"] componentsSeparatedByString:@", "][0];
    }
    else {
        responseContentType = @"";
    }

    // request content type
    NSString *requestContentType = [ASPApiClient selectHeaderContentType:@[@"application/json"]];

    // Authentication setting
    NSArray *authSettings = @[];

    id bodyParam = nil;
    NSMutableDictionary *formParams = [[NSMutableDictionary alloc] init];
    NSMutableDictionary *files = [[NSMutableDictionary alloc] init];
    
    
    

    
    return [self.apiClient requestWithCompletionBlock: resourcePath
                                               method: @"GET"
                                           pathParams: pathParams
                                          queryParams: queryParams
                                           formParams: formParams
                                                files: files
                                                 body: bodyParam
                                         headerParams: headerParams
                                         authSettings: authSettings
                                   requestContentType: requestContentType
                                  responseContentType: responseContentType
                                         responseType: @"ASPSectionResponse*"
                                      completionBlock: ^(id data, NSError *error) {
                  
                  completionBlock((ASPSectionResponse*)data, error);
              }
          ];
}

///
/// Remove fields from section.
/// 
///  @param name The file name.
///
///  @param sectionIndex Section index
///
///  @param storage The document storage.
///
///  @param folder The document folder.
///
///  @returns ASPBaseResponse*
///
-(NSNumber*) deleteSectionFieldsWithCompletionBlock: (NSString*) name
         sectionIndex: (NSNumber*) sectionIndex
         storage: (NSString*) storage
         folder: (NSString*) folder
        
        completionHandler: (void (^)(ASPBaseResponse* output, NSError* error))completionBlock { 
        

    
    // verify the required parameter 'name' is set
    if (name == nil) {
        [NSException raise:@"Invalid parameter" format:@"Missing the required parameter `name` when calling `deleteSectionFields`"];
    }
    
    // verify the required parameter 'sectionIndex' is set
    if (sectionIndex == nil) {
        [NSException raise:@"Invalid parameter" format:@"Missing the required parameter `sectionIndex` when calling `deleteSectionFields`"];
    }
    

    NSMutableString* resourcePath = [NSMutableString stringWithFormat:@"/words/{name}/sections/{sectionIndex}/fields"];

    // remove format in URL if needed
    if ([resourcePath rangeOfString:@".{format}"].location != NSNotFound) {
        [resourcePath replaceCharactersInRange: [resourcePath rangeOfString:@".{format}"] withString:@".json"];
    }

    NSMutableDictionary *pathParams = [[NSMutableDictionary alloc] init];
    if (name != nil) {
        pathParams[@"name"] = name;
    }
    if (sectionIndex != nil) {
        pathParams[@"sectionIndex"] = sectionIndex;
    }
    

    NSMutableDictionary* queryParams = [[NSMutableDictionary alloc] init];
    if(storage != nil) {
        
        queryParams[@"storage"] = storage;
    }
    if(folder != nil) {
        
        queryParams[@"folder"] = folder;
    }
    
    NSMutableDictionary* headerParams = [NSMutableDictionary dictionaryWithDictionary:self.defaultHeaders];

    

    // HTTP header `Accept`
    headerParams[@"Accept"] = [ASPApiClient selectHeaderAccept:@[@"application/json"]];
    if ([headerParams[@"Accept"] length] == 0) {
        [headerParams removeObjectForKey:@"Accept"];
    }

    // response content type
    NSString *responseContentType;
    if ([headerParams objectForKey:@"Accept"]) {
        responseContentType = [headerParams[@"Accept"] componentsSeparatedByString:@", "][0];
    }
    else {
        responseContentType = @"";
    }

    // request content type
    NSString *requestContentType = [ASPApiClient selectHeaderContentType:@[@"application/json"]];

    // Authentication setting
    NSArray *authSettings = @[];

    id bodyParam = nil;
    NSMutableDictionary *formParams = [[NSMutableDictionary alloc] init];
    NSMutableDictionary *files = [[NSMutableDictionary alloc] init];
    
    
    

    
    return [self.apiClient requestWithCompletionBlock: resourcePath
                                               method: @"DELETE"
                                           pathParams: pathParams
                                          queryParams: queryParams
                                           formParams: formParams
                                                files: files
                                                 body: bodyParam
                                         headerParams: headerParams
                                         authSettings: authSettings
                                   requestContentType: requestContentType
                                  responseContentType: responseContentType
                                         responseType: @"ASPBaseResponse*"
                                      completionBlock: ^(id data, NSError *error) {
                  
                  completionBlock((ASPBaseResponse*)data, error);
              }
          ];
}

///
/// Get page setup of section.
/// 
///  @param name The document name.
///
///  @param sectionIndex Section index
///
///  @param storage The document storage.
///
///  @param folder The document folder.
///
///  @returns ASPSectionPageSetupResponse*
///
-(NSNumber*) getSectionPageSetupWithCompletionBlock: (NSString*) name
         sectionIndex: (NSNumber*) sectionIndex
         storage: (NSString*) storage
         folder: (NSString*) folder
        
        completionHandler: (void (^)(ASPSectionPageSetupResponse* output, NSError* error))completionBlock { 
        

    
    // verify the required parameter 'name' is set
    if (name == nil) {
        [NSException raise:@"Invalid parameter" format:@"Missing the required parameter `name` when calling `getSectionPageSetup`"];
    }
    
    // verify the required parameter 'sectionIndex' is set
    if (sectionIndex == nil) {
        [NSException raise:@"Invalid parameter" format:@"Missing the required parameter `sectionIndex` when calling `getSectionPageSetup`"];
    }
    

    NSMutableString* resourcePath = [NSMutableString stringWithFormat:@"/words/{name}/sections/{sectionIndex}/pageSetup"];

    // remove format in URL if needed
    if ([resourcePath rangeOfString:@".{format}"].location != NSNotFound) {
        [resourcePath replaceCharactersInRange: [resourcePath rangeOfString:@".{format}"] withString:@".json"];
    }

    NSMutableDictionary *pathParams = [[NSMutableDictionary alloc] init];
    if (name != nil) {
        pathParams[@"name"] = name;
    }
    if (sectionIndex != nil) {
        pathParams[@"sectionIndex"] = sectionIndex;
    }
    

    NSMutableDictionary* queryParams = [[NSMutableDictionary alloc] init];
    if(storage != nil) {
        
        queryParams[@"storage"] = storage;
    }
    if(folder != nil) {
        
        queryParams[@"folder"] = folder;
    }
    
    NSMutableDictionary* headerParams = [NSMutableDictionary dictionaryWithDictionary:self.defaultHeaders];

    

    // HTTP header `Accept`
    headerParams[@"Accept"] = [ASPApiClient selectHeaderAccept:@[@"application/json"]];
    if ([headerParams[@"Accept"] length] == 0) {
        [headerParams removeObjectForKey:@"Accept"];
    }

    // response content type
    NSString *responseContentType;
    if ([headerParams objectForKey:@"Accept"]) {
        responseContentType = [headerParams[@"Accept"] componentsSeparatedByString:@", "][0];
    }
    else {
        responseContentType = @"";
    }

    // request content type
    NSString *requestContentType = [ASPApiClient selectHeaderContentType:@[@"application/json"]];

    // Authentication setting
    NSArray *authSettings = @[];

    id bodyParam = nil;
    NSMutableDictionary *formParams = [[NSMutableDictionary alloc] init];
    NSMutableDictionary *files = [[NSMutableDictionary alloc] init];
    
    
    

    
    return [self.apiClient requestWithCompletionBlock: resourcePath
                                               method: @"GET"
                                           pathParams: pathParams
                                          queryParams: queryParams
                                           formParams: formParams
                                                files: files
                                                 body: bodyParam
                                         headerParams: headerParams
                                         authSettings: authSettings
                                   requestContentType: requestContentType
                                  responseContentType: responseContentType
                                         responseType: @"ASPSectionPageSetupResponse*"
                                      completionBlock: ^(id data, NSError *error) {
                  
                  completionBlock((ASPSectionPageSetupResponse*)data, error);
              }
          ];
}

///
/// Update page setup of section.
/// 
///  @param name The document name.
///
///  @param sectionIndex Section index
///
///  @param pageSetup Page setup properties
///
///  @param storage The document storage.
///
///  @param folder The document folder.
///
///  @param filename Result name of the document after the operation. If this parameter is omitted then result of the operation will be saved as the source document.
///
///  @returns ASPSectionPageSetupResponse*
///
-(NSNumber*) updateSectionPageSetupWithCompletionBlock: (NSString*) name
         sectionIndex: (NSNumber*) sectionIndex
         pageSetup: (ASPPageSetup*) pageSetup
         storage: (NSString*) storage
         folder: (NSString*) folder
         filename: (NSString*) filename
        
        completionHandler: (void (^)(ASPSectionPageSetupResponse* output, NSError* error))completionBlock { 
        

    
    // verify the required parameter 'name' is set
    if (name == nil) {
        [NSException raise:@"Invalid parameter" format:@"Missing the required parameter `name` when calling `updateSectionPageSetup`"];
    }
    
    // verify the required parameter 'sectionIndex' is set
    if (sectionIndex == nil) {
        [NSException raise:@"Invalid parameter" format:@"Missing the required parameter `sectionIndex` when calling `updateSectionPageSetup`"];
    }
    
    // verify the required parameter 'pageSetup' is set
    if (pageSetup == nil) {
        [NSException raise:@"Invalid parameter" format:@"Missing the required parameter `pageSetup` when calling `updateSectionPageSetup`"];
    }
    

    NSMutableString* resourcePath = [NSMutableString stringWithFormat:@"/words/{name}/sections/{sectionIndex}/pageSetup"];

    // remove format in URL if needed
    if ([resourcePath rangeOfString:@".{format}"].location != NSNotFound) {
        [resourcePath replaceCharactersInRange: [resourcePath rangeOfString:@".{format}"] withString:@".json"];
    }

    NSMutableDictionary *pathParams = [[NSMutableDictionary alloc] init];
    if (name != nil) {
        pathParams[@"name"] = name;
    }
    if (sectionIndex != nil) {
        pathParams[@"sectionIndex"] = sectionIndex;
    }
    

    NSMutableDictionary* queryParams = [[NSMutableDictionary alloc] init];
    if(storage != nil) {
        
        queryParams[@"storage"] = storage;
    }
    if(folder != nil) {
        
        queryParams[@"folder"] = folder;
    }
    if(filename != nil) {
        
        queryParams[@"filename"] = filename;
    }
    
    NSMutableDictionary* headerParams = [NSMutableDictionary dictionaryWithDictionary:self.defaultHeaders];

    

    // HTTP header `Accept`
    headerParams[@"Accept"] = [ASPApiClient selectHeaderAccept:@[@"application/json"]];
    if ([headerParams[@"Accept"] length] == 0) {
        [headerParams removeObjectForKey:@"Accept"];
    }

    // response content type
    NSString *responseContentType;
    if ([headerParams objectForKey:@"Accept"]) {
        responseContentType = [headerParams[@"Accept"] componentsSeparatedByString:@", "][0];
    }
    else {
        responseContentType = @"";
    }

    // request content type
    NSString *requestContentType = [ASPApiClient selectHeaderContentType:@[@"application/json"]];

    // Authentication setting
    NSArray *authSettings = @[];

    id bodyParam = nil;
    NSMutableDictionary *formParams = [[NSMutableDictionary alloc] init];
    NSMutableDictionary *files = [[NSMutableDictionary alloc] init];
    
    bodyParam = pageSetup;
    

    
    return [self.apiClient requestWithCompletionBlock: resourcePath
                                               method: @"POST"
                                           pathParams: pathParams
                                          queryParams: queryParams
                                           formParams: formParams
                                                files: files
                                                 body: bodyParam
                                         headerParams: headerParams
                                         authSettings: authSettings
                                   requestContentType: requestContentType
                                  responseContentType: responseContentType
                                         responseType: @"ASPSectionPageSetupResponse*"
                                      completionBlock: ^(id data, NSError *error) {
                  
                  completionBlock((ASPSectionPageSetupResponse*)data, error);
              }
          ];
}

///
/// 
/// 
///  @param name 
///
///  @param sectionIndex 
///
///  @param paragraphIndex 
///
///  @param field 
///
///  @param insertBeforeNode 
///
///  @param destFileName 
///
///  @param storage 
///
///  @param folder 
///
///  @returns ASPFieldResponse*
///
-(NSNumber*) putFieldWithCompletionBlock: (NSString*) name
         sectionIndex: (NSNumber*) sectionIndex
         paragraphIndex: (NSNumber*) paragraphIndex
         field: (ASPField*) field
         insertBeforeNode: (NSString*) insertBeforeNode
         destFileName: (NSString*) destFileName
         storage: (NSString*) storage
         folder: (NSString*) folder
        
        completionHandler: (void (^)(ASPFieldResponse* output, NSError* error))completionBlock { 
        

    
    // verify the required parameter 'name' is set
    if (name == nil) {
        [NSException raise:@"Invalid parameter" format:@"Missing the required parameter `name` when calling `putField`"];
    }
    
    // verify the required parameter 'sectionIndex' is set
    if (sectionIndex == nil) {
        [NSException raise:@"Invalid parameter" format:@"Missing the required parameter `sectionIndex` when calling `putField`"];
    }
    
    // verify the required parameter 'paragraphIndex' is set
    if (paragraphIndex == nil) {
        [NSException raise:@"Invalid parameter" format:@"Missing the required parameter `paragraphIndex` when calling `putField`"];
    }
    
    // verify the required parameter 'field' is set
    if (field == nil) {
        [NSException raise:@"Invalid parameter" format:@"Missing the required parameter `field` when calling `putField`"];
    }
    

    NSMutableString* resourcePath = [NSMutableString stringWithFormat:@"/words/{name}/sections/{sectionIndex}/paragraphs/{paragraphIndex}/fields"];

    // remove format in URL if needed
    if ([resourcePath rangeOfString:@".{format}"].location != NSNotFound) {
        [resourcePath replaceCharactersInRange: [resourcePath rangeOfString:@".{format}"] withString:@".json"];
    }

    NSMutableDictionary *pathParams = [[NSMutableDictionary alloc] init];
    if (name != nil) {
        pathParams[@"name"] = name;
    }
    if (sectionIndex != nil) {
        pathParams[@"sectionIndex"] = sectionIndex;
    }
    if (paragraphIndex != nil) {
        pathParams[@"paragraphIndex"] = paragraphIndex;
    }
    

    NSMutableDictionary* queryParams = [[NSMutableDictionary alloc] init];
    if(insertBeforeNode != nil) {
        
        queryParams[@"insertBeforeNode"] = insertBeforeNode;
    }
    if(destFileName != nil) {
        
        queryParams[@"destFileName"] = destFileName;
    }
    if(storage != nil) {
        
        queryParams[@"storage"] = storage;
    }
    if(folder != nil) {
        
        queryParams[@"folder"] = folder;
    }
    
    NSMutableDictionary* headerParams = [NSMutableDictionary dictionaryWithDictionary:self.defaultHeaders];

    

    // HTTP header `Accept`
    headerParams[@"Accept"] = [ASPApiClient selectHeaderAccept:@[@"application/json"]];
    if ([headerParams[@"Accept"] length] == 0) {
        [headerParams removeObjectForKey:@"Accept"];
    }

    // response content type
    NSString *responseContentType;
    if ([headerParams objectForKey:@"Accept"]) {
        responseContentType = [headerParams[@"Accept"] componentsSeparatedByString:@", "][0];
    }
    else {
        responseContentType = @"";
    }

    // request content type
    NSString *requestContentType = [ASPApiClient selectHeaderContentType:@[@"application/json"]];

    // Authentication setting
    NSArray *authSettings = @[];

    id bodyParam = nil;
    NSMutableDictionary *formParams = [[NSMutableDictionary alloc] init];
    NSMutableDictionary *files = [[NSMutableDictionary alloc] init];
    
    bodyParam = field;
    

    
    return [self.apiClient requestWithCompletionBlock: resourcePath
                                               method: @"PUT"
                                           pathParams: pathParams
                                          queryParams: queryParams
                                           formParams: formParams
                                                files: files
                                                 body: bodyParam
                                         headerParams: headerParams
                                         authSettings: authSettings
                                   requestContentType: requestContentType
                                  responseContentType: responseContentType
                                         responseType: @"ASPFieldResponse*"
                                      completionBlock: ^(id data, NSError *error) {
                  
                  completionBlock((ASPFieldResponse*)data, error);
              }
          ];
}

///
/// 
/// 
///  @param name 
///
///  @param sectionIndex 
///
///  @param paragraphIndex 
///
///  @param fieldIndex 
///
///  @param storage 
///
///  @param folder 
///
///  @returns ASPFieldResponse*
///
-(NSNumber*) getFieldWithCompletionBlock: (NSString*) name
         sectionIndex: (NSNumber*) sectionIndex
         paragraphIndex: (NSNumber*) paragraphIndex
         fieldIndex: (NSNumber*) fieldIndex
         storage: (NSString*) storage
         folder: (NSString*) folder
        
        completionHandler: (void (^)(ASPFieldResponse* output, NSError* error))completionBlock { 
        

    
    // verify the required parameter 'name' is set
    if (name == nil) {
        [NSException raise:@"Invalid parameter" format:@"Missing the required parameter `name` when calling `getField`"];
    }
    
    // verify the required parameter 'sectionIndex' is set
    if (sectionIndex == nil) {
        [NSException raise:@"Invalid parameter" format:@"Missing the required parameter `sectionIndex` when calling `getField`"];
    }
    
    // verify the required parameter 'paragraphIndex' is set
    if (paragraphIndex == nil) {
        [NSException raise:@"Invalid parameter" format:@"Missing the required parameter `paragraphIndex` when calling `getField`"];
    }
    
    // verify the required parameter 'fieldIndex' is set
    if (fieldIndex == nil) {
        [NSException raise:@"Invalid parameter" format:@"Missing the required parameter `fieldIndex` when calling `getField`"];
    }
    

    NSMutableString* resourcePath = [NSMutableString stringWithFormat:@"/words/{name}/sections/{sectionIndex}/paragraphs/{paragraphIndex}/fields/{fieldIndex}"];

    // remove format in URL if needed
    if ([resourcePath rangeOfString:@".{format}"].location != NSNotFound) {
        [resourcePath replaceCharactersInRange: [resourcePath rangeOfString:@".{format}"] withString:@".json"];
    }

    NSMutableDictionary *pathParams = [[NSMutableDictionary alloc] init];
    if (name != nil) {
        pathParams[@"name"] = name;
    }
    if (sectionIndex != nil) {
        pathParams[@"sectionIndex"] = sectionIndex;
    }
    if (paragraphIndex != nil) {
        pathParams[@"paragraphIndex"] = paragraphIndex;
    }
    if (fieldIndex != nil) {
        pathParams[@"fieldIndex"] = fieldIndex;
    }
    

    NSMutableDictionary* queryParams = [[NSMutableDictionary alloc] init];
    if(storage != nil) {
        
        queryParams[@"storage"] = storage;
    }
    if(folder != nil) {
        
        queryParams[@"folder"] = folder;
    }
    
    NSMutableDictionary* headerParams = [NSMutableDictionary dictionaryWithDictionary:self.defaultHeaders];

    

    // HTTP header `Accept`
    headerParams[@"Accept"] = [ASPApiClient selectHeaderAccept:@[@"application/json"]];
    if ([headerParams[@"Accept"] length] == 0) {
        [headerParams removeObjectForKey:@"Accept"];
    }

    // response content type
    NSString *responseContentType;
    if ([headerParams objectForKey:@"Accept"]) {
        responseContentType = [headerParams[@"Accept"] componentsSeparatedByString:@", "][0];
    }
    else {
        responseContentType = @"";
    }

    // request content type
    NSString *requestContentType = [ASPApiClient selectHeaderContentType:@[@"application/json"]];

    // Authentication setting
    NSArray *authSettings = @[];

    id bodyParam = nil;
    NSMutableDictionary *formParams = [[NSMutableDictionary alloc] init];
    NSMutableDictionary *files = [[NSMutableDictionary alloc] init];
    
    
    

    
    return [self.apiClient requestWithCompletionBlock: resourcePath
                                               method: @"GET"
                                           pathParams: pathParams
                                          queryParams: queryParams
                                           formParams: formParams
                                                files: files
                                                 body: bodyParam
                                         headerParams: headerParams
                                         authSettings: authSettings
                                   requestContentType: requestContentType
                                  responseContentType: responseContentType
                                         responseType: @"ASPFieldResponse*"
                                      completionBlock: ^(id data, NSError *error) {
                  
                  completionBlock((ASPFieldResponse*)data, error);
              }
          ];
}

///
/// 
/// 
///  @param name 
///
///  @param sectionIndex 
///
///  @param paragraphIndex 
///
///  @param fieldIndex 
///
///  @param field 
///
///  @param destFileName 
///
///  @param storage 
///
///  @param folder 
///
///  @returns ASPFieldResponse*
///
-(NSNumber*) postFieldWithCompletionBlock: (NSString*) name
         sectionIndex: (NSNumber*) sectionIndex
         paragraphIndex: (NSNumber*) paragraphIndex
         fieldIndex: (NSNumber*) fieldIndex
         field: (ASPField*) field
         destFileName: (NSString*) destFileName
         storage: (NSString*) storage
         folder: (NSString*) folder
        
        completionHandler: (void (^)(ASPFieldResponse* output, NSError* error))completionBlock { 
        

    
    // verify the required parameter 'name' is set
    if (name == nil) {
        [NSException raise:@"Invalid parameter" format:@"Missing the required parameter `name` when calling `postField`"];
    }
    
    // verify the required parameter 'sectionIndex' is set
    if (sectionIndex == nil) {
        [NSException raise:@"Invalid parameter" format:@"Missing the required parameter `sectionIndex` when calling `postField`"];
    }
    
    // verify the required parameter 'paragraphIndex' is set
    if (paragraphIndex == nil) {
        [NSException raise:@"Invalid parameter" format:@"Missing the required parameter `paragraphIndex` when calling `postField`"];
    }
    
    // verify the required parameter 'fieldIndex' is set
    if (fieldIndex == nil) {
        [NSException raise:@"Invalid parameter" format:@"Missing the required parameter `fieldIndex` when calling `postField`"];
    }
    
    // verify the required parameter 'field' is set
    if (field == nil) {
        [NSException raise:@"Invalid parameter" format:@"Missing the required parameter `field` when calling `postField`"];
    }
    

    NSMutableString* resourcePath = [NSMutableString stringWithFormat:@"/words/{name}/sections/{sectionIndex}/paragraphs/{paragraphIndex}/fields/{fieldIndex}"];

    // remove format in URL if needed
    if ([resourcePath rangeOfString:@".{format}"].location != NSNotFound) {
        [resourcePath replaceCharactersInRange: [resourcePath rangeOfString:@".{format}"] withString:@".json"];
    }

    NSMutableDictionary *pathParams = [[NSMutableDictionary alloc] init];
    if (name != nil) {
        pathParams[@"name"] = name;
    }
    if (sectionIndex != nil) {
        pathParams[@"sectionIndex"] = sectionIndex;
    }
    if (paragraphIndex != nil) {
        pathParams[@"paragraphIndex"] = paragraphIndex;
    }
    if (fieldIndex != nil) {
        pathParams[@"fieldIndex"] = fieldIndex;
    }
    

    NSMutableDictionary* queryParams = [[NSMutableDictionary alloc] init];
    if(destFileName != nil) {
        
        queryParams[@"destFileName"] = destFileName;
    }
    if(storage != nil) {
        
        queryParams[@"storage"] = storage;
    }
    if(folder != nil) {
        
        queryParams[@"folder"] = folder;
    }
    
    NSMutableDictionary* headerParams = [NSMutableDictionary dictionaryWithDictionary:self.defaultHeaders];

    

    // HTTP header `Accept`
    headerParams[@"Accept"] = [ASPApiClient selectHeaderAccept:@[@"application/json"]];
    if ([headerParams[@"Accept"] length] == 0) {
        [headerParams removeObjectForKey:@"Accept"];
    }

    // response content type
    NSString *responseContentType;
    if ([headerParams objectForKey:@"Accept"]) {
        responseContentType = [headerParams[@"Accept"] componentsSeparatedByString:@", "][0];
    }
    else {
        responseContentType = @"";
    }

    // request content type
    NSString *requestContentType = [ASPApiClient selectHeaderContentType:@[@"application/json"]];

    // Authentication setting
    NSArray *authSettings = @[];

    id bodyParam = nil;
    NSMutableDictionary *formParams = [[NSMutableDictionary alloc] init];
    NSMutableDictionary *files = [[NSMutableDictionary alloc] init];
    
    bodyParam = field;
    

    
    return [self.apiClient requestWithCompletionBlock: resourcePath
                                               method: @"POST"
                                           pathParams: pathParams
                                          queryParams: queryParams
                                           formParams: formParams
                                                files: files
                                                 body: bodyParam
                                         headerParams: headerParams
                                         authSettings: authSettings
                                   requestContentType: requestContentType
                                  responseContentType: responseContentType
                                         responseType: @"ASPFieldResponse*"
                                      completionBlock: ^(id data, NSError *error) {
                  
                  completionBlock((ASPFieldResponse*)data, error);
              }
          ];
}

///
/// Adds form field to paragraph, returns added form field's data.
/// 
///  @param name The document name.
///
///  @param sectionIndex Section index.
///
///  @param paragraphIndex Paragraph index.
///
///  @param formField From field data.
///
///  @param insertBeforeNode Form field will be inserted before node with index.
///
///  @param destFileName Destination file name.
///
///  @param storage The document storage.
///
///  @param folder The document folder.
///
///  @returns ASPFormFieldResponse*
///
-(NSNumber*) putFormFieldWithCompletionBlock: (NSString*) name
         sectionIndex: (NSNumber*) sectionIndex
         paragraphIndex: (NSNumber*) paragraphIndex
         formField: (ASPFormField*) formField
         insertBeforeNode: (NSString*) insertBeforeNode
         destFileName: (NSString*) destFileName
         storage: (NSString*) storage
         folder: (NSString*) folder
        
        completionHandler: (void (^)(ASPFormFieldResponse* output, NSError* error))completionBlock { 
        

    
    // verify the required parameter 'name' is set
    if (name == nil) {
        [NSException raise:@"Invalid parameter" format:@"Missing the required parameter `name` when calling `putFormField`"];
    }
    
    // verify the required parameter 'sectionIndex' is set
    if (sectionIndex == nil) {
        [NSException raise:@"Invalid parameter" format:@"Missing the required parameter `sectionIndex` when calling `putFormField`"];
    }
    
    // verify the required parameter 'paragraphIndex' is set
    if (paragraphIndex == nil) {
        [NSException raise:@"Invalid parameter" format:@"Missing the required parameter `paragraphIndex` when calling `putFormField`"];
    }
    
    // verify the required parameter 'formField' is set
    if (formField == nil) {
        [NSException raise:@"Invalid parameter" format:@"Missing the required parameter `formField` when calling `putFormField`"];
    }
    

    NSMutableString* resourcePath = [NSMutableString stringWithFormat:@"/words/{name}/sections/{sectionIndex}/paragraphs/{paragraphIndex}/formfields"];

    // remove format in URL if needed
    if ([resourcePath rangeOfString:@".{format}"].location != NSNotFound) {
        [resourcePath replaceCharactersInRange: [resourcePath rangeOfString:@".{format}"] withString:@".json"];
    }

    NSMutableDictionary *pathParams = [[NSMutableDictionary alloc] init];
    if (name != nil) {
        pathParams[@"name"] = name;
    }
    if (sectionIndex != nil) {
        pathParams[@"sectionIndex"] = sectionIndex;
    }
    if (paragraphIndex != nil) {
        pathParams[@"paragraphIndex"] = paragraphIndex;
    }
    

    NSMutableDictionary* queryParams = [[NSMutableDictionary alloc] init];
    if(insertBeforeNode != nil) {
        
        queryParams[@"insertBeforeNode"] = insertBeforeNode;
    }
    if(destFileName != nil) {
        
        queryParams[@"destFileName"] = destFileName;
    }
    if(storage != nil) {
        
        queryParams[@"storage"] = storage;
    }
    if(folder != nil) {
        
        queryParams[@"folder"] = folder;
    }
    
    NSMutableDictionary* headerParams = [NSMutableDictionary dictionaryWithDictionary:self.defaultHeaders];

    

    // HTTP header `Accept`
    headerParams[@"Accept"] = [ASPApiClient selectHeaderAccept:@[@"application/json"]];
    if ([headerParams[@"Accept"] length] == 0) {
        [headerParams removeObjectForKey:@"Accept"];
    }

    // response content type
    NSString *responseContentType;
    if ([headerParams objectForKey:@"Accept"]) {
        responseContentType = [headerParams[@"Accept"] componentsSeparatedByString:@", "][0];
    }
    else {
        responseContentType = @"";
    }

    // request content type
    NSString *requestContentType = [ASPApiClient selectHeaderContentType:@[@"application/json"]];

    // Authentication setting
    NSArray *authSettings = @[];

    id bodyParam = nil;
    NSMutableDictionary *formParams = [[NSMutableDictionary alloc] init];
    NSMutableDictionary *files = [[NSMutableDictionary alloc] init];
    
    bodyParam = formField;
    

    
    return [self.apiClient requestWithCompletionBlock: resourcePath
                                               method: @"PUT"
                                           pathParams: pathParams
                                          queryParams: queryParams
                                           formParams: formParams
                                                files: files
                                                 body: bodyParam
                                         headerParams: headerParams
                                         authSettings: authSettings
                                   requestContentType: requestContentType
                                  responseContentType: responseContentType
                                         responseType: @"ASPFormFieldResponse*"
                                      completionBlock: ^(id data, NSError *error) {
                  
                  completionBlock((ASPFormFieldResponse*)data, error);
              }
          ];
}

///
/// Returns representation of an one of the form field.
/// 
///  @param name The document name.
///
///  @param sectionIndex Section index.
///
///  @param paragraphIndex Paragraph index.
///
///  @param formfieldIndex Form field index.
///
///  @param storage The document storage.
///
///  @param folder The document folder.
///
///  @returns ASPFormFieldResponse*
///
-(NSNumber*) getFormFieldWithCompletionBlock: (NSString*) name
         sectionIndex: (NSNumber*) sectionIndex
         paragraphIndex: (NSNumber*) paragraphIndex
         formfieldIndex: (NSNumber*) formfieldIndex
         storage: (NSString*) storage
         folder: (NSString*) folder
        
        completionHandler: (void (^)(ASPFormFieldResponse* output, NSError* error))completionBlock { 
        

    
    // verify the required parameter 'name' is set
    if (name == nil) {
        [NSException raise:@"Invalid parameter" format:@"Missing the required parameter `name` when calling `getFormField`"];
    }
    
    // verify the required parameter 'sectionIndex' is set
    if (sectionIndex == nil) {
        [NSException raise:@"Invalid parameter" format:@"Missing the required parameter `sectionIndex` when calling `getFormField`"];
    }
    
    // verify the required parameter 'paragraphIndex' is set
    if (paragraphIndex == nil) {
        [NSException raise:@"Invalid parameter" format:@"Missing the required parameter `paragraphIndex` when calling `getFormField`"];
    }
    
    // verify the required parameter 'formfieldIndex' is set
    if (formfieldIndex == nil) {
        [NSException raise:@"Invalid parameter" format:@"Missing the required parameter `formfieldIndex` when calling `getFormField`"];
    }
    

    NSMutableString* resourcePath = [NSMutableString stringWithFormat:@"/words/{name}/sections/{sectionIndex}/paragraphs/{paragraphIndex}/formfields/{formfieldIndex}"];

    // remove format in URL if needed
    if ([resourcePath rangeOfString:@".{format}"].location != NSNotFound) {
        [resourcePath replaceCharactersInRange: [resourcePath rangeOfString:@".{format}"] withString:@".json"];
    }

    NSMutableDictionary *pathParams = [[NSMutableDictionary alloc] init];
    if (name != nil) {
        pathParams[@"name"] = name;
    }
    if (sectionIndex != nil) {
        pathParams[@"sectionIndex"] = sectionIndex;
    }
    if (paragraphIndex != nil) {
        pathParams[@"paragraphIndex"] = paragraphIndex;
    }
    if (formfieldIndex != nil) {
        pathParams[@"formfieldIndex"] = formfieldIndex;
    }
    

    NSMutableDictionary* queryParams = [[NSMutableDictionary alloc] init];
    if(storage != nil) {
        
        queryParams[@"storage"] = storage;
    }
    if(folder != nil) {
        
        queryParams[@"folder"] = folder;
    }
    
    NSMutableDictionary* headerParams = [NSMutableDictionary dictionaryWithDictionary:self.defaultHeaders];

    

    // HTTP header `Accept`
    headerParams[@"Accept"] = [ASPApiClient selectHeaderAccept:@[@"application/json"]];
    if ([headerParams[@"Accept"] length] == 0) {
        [headerParams removeObjectForKey:@"Accept"];
    }

    // response content type
    NSString *responseContentType;
    if ([headerParams objectForKey:@"Accept"]) {
        responseContentType = [headerParams[@"Accept"] componentsSeparatedByString:@", "][0];
    }
    else {
        responseContentType = @"";
    }

    // request content type
    NSString *requestContentType = [ASPApiClient selectHeaderContentType:@[@"application/json"]];

    // Authentication setting
    NSArray *authSettings = @[];

    id bodyParam = nil;
    NSMutableDictionary *formParams = [[NSMutableDictionary alloc] init];
    NSMutableDictionary *files = [[NSMutableDictionary alloc] init];
    
    
    

    
    return [self.apiClient requestWithCompletionBlock: resourcePath
                                               method: @"GET"
                                           pathParams: pathParams
                                          queryParams: queryParams
                                           formParams: formParams
                                                files: files
                                                 body: bodyParam
                                         headerParams: headerParams
                                         authSettings: authSettings
                                   requestContentType: requestContentType
                                  responseContentType: responseContentType
                                         responseType: @"ASPFormFieldResponse*"
                                      completionBlock: ^(id data, NSError *error) {
                  
                  completionBlock((ASPFormFieldResponse*)data, error);
              }
          ];
}

///
/// Updates form field's properties, returns updated form field's data.
/// 
///  @param name The document name.
///
///  @param sectionIndex Section index.
///
///  @param paragraphIndex Paragraph index.
///
///  @param formfieldIndex Form field index.
///
///  @param formField From field data.
///
///  @param destFileName Destination file name.
///
///  @param storage The document storage.
///
///  @param folder The document folder.
///
///  @returns ASPFormFieldResponse*
///
-(NSNumber*) postFormFieldWithCompletionBlock: (NSString*) name
         sectionIndex: (NSNumber*) sectionIndex
         paragraphIndex: (NSNumber*) paragraphIndex
         formfieldIndex: (NSNumber*) formfieldIndex
         formField: (ASPFormField*) formField
         destFileName: (NSString*) destFileName
         storage: (NSString*) storage
         folder: (NSString*) folder
        
        completionHandler: (void (^)(ASPFormFieldResponse* output, NSError* error))completionBlock { 
        

    
    // verify the required parameter 'name' is set
    if (name == nil) {
        [NSException raise:@"Invalid parameter" format:@"Missing the required parameter `name` when calling `postFormField`"];
    }
    
    // verify the required parameter 'sectionIndex' is set
    if (sectionIndex == nil) {
        [NSException raise:@"Invalid parameter" format:@"Missing the required parameter `sectionIndex` when calling `postFormField`"];
    }
    
    // verify the required parameter 'paragraphIndex' is set
    if (paragraphIndex == nil) {
        [NSException raise:@"Invalid parameter" format:@"Missing the required parameter `paragraphIndex` when calling `postFormField`"];
    }
    
    // verify the required parameter 'formfieldIndex' is set
    if (formfieldIndex == nil) {
        [NSException raise:@"Invalid parameter" format:@"Missing the required parameter `formfieldIndex` when calling `postFormField`"];
    }
    
    // verify the required parameter 'formField' is set
    if (formField == nil) {
        [NSException raise:@"Invalid parameter" format:@"Missing the required parameter `formField` when calling `postFormField`"];
    }
    

    NSMutableString* resourcePath = [NSMutableString stringWithFormat:@"/words/{name}/sections/{sectionIndex}/paragraphs/{paragraphIndex}/formfields/{formfieldIndex}"];

    // remove format in URL if needed
    if ([resourcePath rangeOfString:@".{format}"].location != NSNotFound) {
        [resourcePath replaceCharactersInRange: [resourcePath rangeOfString:@".{format}"] withString:@".json"];
    }

    NSMutableDictionary *pathParams = [[NSMutableDictionary alloc] init];
    if (name != nil) {
        pathParams[@"name"] = name;
    }
    if (sectionIndex != nil) {
        pathParams[@"sectionIndex"] = sectionIndex;
    }
    if (paragraphIndex != nil) {
        pathParams[@"paragraphIndex"] = paragraphIndex;
    }
    if (formfieldIndex != nil) {
        pathParams[@"formfieldIndex"] = formfieldIndex;
    }
    

    NSMutableDictionary* queryParams = [[NSMutableDictionary alloc] init];
    if(destFileName != nil) {
        
        queryParams[@"destFileName"] = destFileName;
    }
    if(storage != nil) {
        
        queryParams[@"storage"] = storage;
    }
    if(folder != nil) {
        
        queryParams[@"folder"] = folder;
    }
    
    NSMutableDictionary* headerParams = [NSMutableDictionary dictionaryWithDictionary:self.defaultHeaders];

    

    // HTTP header `Accept`
    headerParams[@"Accept"] = [ASPApiClient selectHeaderAccept:@[@"application/json"]];
    if ([headerParams[@"Accept"] length] == 0) {
        [headerParams removeObjectForKey:@"Accept"];
    }

    // response content type
    NSString *responseContentType;
    if ([headerParams objectForKey:@"Accept"]) {
        responseContentType = [headerParams[@"Accept"] componentsSeparatedByString:@", "][0];
    }
    else {
        responseContentType = @"";
    }

    // request content type
    NSString *requestContentType = [ASPApiClient selectHeaderContentType:@[@"application/json"]];

    // Authentication setting
    NSArray *authSettings = @[];

    id bodyParam = nil;
    NSMutableDictionary *formParams = [[NSMutableDictionary alloc] init];
    NSMutableDictionary *files = [[NSMutableDictionary alloc] init];
    
    bodyParam = formField;
    

    
    return [self.apiClient requestWithCompletionBlock: resourcePath
                                               method: @"POST"
                                           pathParams: pathParams
                                          queryParams: queryParams
                                           formParams: formParams
                                                files: files
                                                 body: bodyParam
                                         headerParams: headerParams
                                         authSettings: authSettings
                                   requestContentType: requestContentType
                                  responseContentType: responseContentType
                                         responseType: @"ASPFormFieldResponse*"
                                      completionBlock: ^(id data, NSError *error) {
                  
                  completionBlock((ASPFormFieldResponse*)data, error);
              }
          ];
}

///
/// Removes form field from document.
/// 
///  @param name The document name.
///
///  @param sectionIndex Section index.
///
///  @param paragraphIndex Paragraph index.
///
///  @param formfieldIndex Form field index.
///
///  @param destFileName Destination file name.
///
///  @param storage The document storage.
///
///  @param folder The document folder.
///
///  @returns ASPBaseResponse*
///
-(NSNumber*) deleteFormFieldWithCompletionBlock: (NSString*) name
         sectionIndex: (NSNumber*) sectionIndex
         paragraphIndex: (NSNumber*) paragraphIndex
         formfieldIndex: (NSNumber*) formfieldIndex
         destFileName: (NSString*) destFileName
         storage: (NSString*) storage
         folder: (NSString*) folder
        
        completionHandler: (void (^)(ASPBaseResponse* output, NSError* error))completionBlock { 
        

    
    // verify the required parameter 'name' is set
    if (name == nil) {
        [NSException raise:@"Invalid parameter" format:@"Missing the required parameter `name` when calling `deleteFormField`"];
    }
    
    // verify the required parameter 'sectionIndex' is set
    if (sectionIndex == nil) {
        [NSException raise:@"Invalid parameter" format:@"Missing the required parameter `sectionIndex` when calling `deleteFormField`"];
    }
    
    // verify the required parameter 'paragraphIndex' is set
    if (paragraphIndex == nil) {
        [NSException raise:@"Invalid parameter" format:@"Missing the required parameter `paragraphIndex` when calling `deleteFormField`"];
    }
    
    // verify the required parameter 'formfieldIndex' is set
    if (formfieldIndex == nil) {
        [NSException raise:@"Invalid parameter" format:@"Missing the required parameter `formfieldIndex` when calling `deleteFormField`"];
    }
    

    NSMutableString* resourcePath = [NSMutableString stringWithFormat:@"/words/{name}/sections/{sectionIndex}/paragraphs/{paragraphIndex}/formfields/{formfieldIndex}"];

    // remove format in URL if needed
    if ([resourcePath rangeOfString:@".{format}"].location != NSNotFound) {
        [resourcePath replaceCharactersInRange: [resourcePath rangeOfString:@".{format}"] withString:@".json"];
    }

    NSMutableDictionary *pathParams = [[NSMutableDictionary alloc] init];
    if (name != nil) {
        pathParams[@"name"] = name;
    }
    if (sectionIndex != nil) {
        pathParams[@"sectionIndex"] = sectionIndex;
    }
    if (paragraphIndex != nil) {
        pathParams[@"paragraphIndex"] = paragraphIndex;
    }
    if (formfieldIndex != nil) {
        pathParams[@"formfieldIndex"] = formfieldIndex;
    }
    

    NSMutableDictionary* queryParams = [[NSMutableDictionary alloc] init];
    if(destFileName != nil) {
        
        queryParams[@"destFileName"] = destFileName;
    }
    if(storage != nil) {
        
        queryParams[@"storage"] = storage;
    }
    if(folder != nil) {
        
        queryParams[@"folder"] = folder;
    }
    
    NSMutableDictionary* headerParams = [NSMutableDictionary dictionaryWithDictionary:self.defaultHeaders];

    

    // HTTP header `Accept`
    headerParams[@"Accept"] = [ASPApiClient selectHeaderAccept:@[@"application/json"]];
    if ([headerParams[@"Accept"] length] == 0) {
        [headerParams removeObjectForKey:@"Accept"];
    }

    // response content type
    NSString *responseContentType;
    if ([headerParams objectForKey:@"Accept"]) {
        responseContentType = [headerParams[@"Accept"] componentsSeparatedByString:@", "][0];
    }
    else {
        responseContentType = @"";
    }

    // request content type
    NSString *requestContentType = [ASPApiClient selectHeaderContentType:@[@"application/json"]];

    // Authentication setting
    NSArray *authSettings = @[];

    id bodyParam = nil;
    NSMutableDictionary *formParams = [[NSMutableDictionary alloc] init];
    NSMutableDictionary *files = [[NSMutableDictionary alloc] init];
    
    
    

    
    return [self.apiClient requestWithCompletionBlock: resourcePath
                                               method: @"DELETE"
                                           pathParams: pathParams
                                          queryParams: queryParams
                                           formParams: formParams
                                                files: files
                                                 body: bodyParam
                                         headerParams: headerParams
                                         authSettings: authSettings
                                   requestContentType: requestContentType
                                  responseContentType: responseContentType
                                         responseType: @"ASPBaseResponse*"
                                      completionBlock: ^(id data, NSError *error) {
                  
                  completionBlock((ASPBaseResponse*)data, error);
              }
          ];
}

///
/// Split document.
/// 
///  @param name Original document name.
///
///  @param format Format to split.
///
///  @param from Start page.
///
///  @param to End page.
///
///  @param zipOutput ZipOutput or not.
///
///  @param storage The document storage.
///
///  @param folder The document folder.
///
///  @returns ASPSplitDocumentResponse*
///
-(NSNumber*) postSplitDocumentWithCompletionBlock: (NSString*) name
         format: (NSString*) format
         from: (NSNumber*) from
         to: (NSNumber*) to
         zipOutput: (NSNumber*) zipOutput
         storage: (NSString*) storage
         folder: (NSString*) folder
        
        completionHandler: (void (^)(ASPSplitDocumentResponse* output, NSError* error))completionBlock { 
        

    
    // verify the required parameter 'name' is set
    if (name == nil) {
        [NSException raise:@"Invalid parameter" format:@"Missing the required parameter `name` when calling `postSplitDocument`"];
    }
    

    NSMutableString* resourcePath = [NSMutableString stringWithFormat:@"/words/{name}/split"];

    // remove format in URL if needed
    if ([resourcePath rangeOfString:@".{format}"].location != NSNotFound) {
        [resourcePath replaceCharactersInRange: [resourcePath rangeOfString:@".{format}"] withString:@".json"];
    }

    NSMutableDictionary *pathParams = [[NSMutableDictionary alloc] init];
    if (name != nil) {
        pathParams[@"name"] = name;
    }
    

    NSMutableDictionary* queryParams = [[NSMutableDictionary alloc] init];
    if(format != nil) {
        
        queryParams[@"format"] = format;
    }
    if(from != nil) {
        
        queryParams[@"from"] = from;
    }
    if(to != nil) {
        
        queryParams[@"to"] = to;
    }
    if(zipOutput != nil) {
        
        queryParams[@"zipOutput"] = zipOutput;
    }
    if(storage != nil) {
        
        queryParams[@"storage"] = storage;
    }
    if(folder != nil) {
        
        queryParams[@"folder"] = folder;
    }
    
    NSMutableDictionary* headerParams = [NSMutableDictionary dictionaryWithDictionary:self.defaultHeaders];

    

    // HTTP header `Accept`
    headerParams[@"Accept"] = [ASPApiClient selectHeaderAccept:@[@"application/json"]];
    if ([headerParams[@"Accept"] length] == 0) {
        [headerParams removeObjectForKey:@"Accept"];
    }

    // response content type
    NSString *responseContentType;
    if ([headerParams objectForKey:@"Accept"]) {
        responseContentType = [headerParams[@"Accept"] componentsSeparatedByString:@", "][0];
    }
    else {
        responseContentType = @"";
    }

    // request content type
    NSString *requestContentType = [ASPApiClient selectHeaderContentType:@[@"application/json"]];

    // Authentication setting
    NSArray *authSettings = @[];

    id bodyParam = nil;
    NSMutableDictionary *formParams = [[NSMutableDictionary alloc] init];
    NSMutableDictionary *files = [[NSMutableDictionary alloc] init];
    
    
    

    
    return [self.apiClient requestWithCompletionBlock: resourcePath
                                               method: @"POST"
                                           pathParams: pathParams
                                          queryParams: queryParams
                                           formParams: formParams
                                                files: files
                                                 body: bodyParam
                                         headerParams: headerParams
                                         authSettings: authSettings
                                   requestContentType: requestContentType
                                  responseContentType: responseContentType
                                         responseType: @"ASPSplitDocumentResponse*"
                                      completionBlock: ^(id data, NSError *error) {
                  
                  completionBlock((ASPSplitDocumentResponse*)data, error);
              }
          ];
}

///
/// Read document statistics.
/// 
///  @param name The document name.
///
///  @param includeComments Support including/excluding comments from the WordCount. Default value is \"true\".
///
///  @param includeFootnotes Support including/excluding footnotes from the WordCount. Default value is \"false\".
///
///  @param includeTextInShapes Support including/excluding shape's text from the WordCount. Default value is \"false\"
///
///  @param storage The document storage.
///
///  @param folder The document folder.
///
///  @returns ASPStatDataResponse*
///
-(NSNumber*) getDocumentStatisticsWithCompletionBlock: (NSString*) name
         includeComments: (NSNumber*) includeComments
         includeFootnotes: (NSNumber*) includeFootnotes
         includeTextInShapes: (NSNumber*) includeTextInShapes
         storage: (NSString*) storage
         folder: (NSString*) folder
        
        completionHandler: (void (^)(ASPStatDataResponse* output, NSError* error))completionBlock { 
        

    
    // verify the required parameter 'name' is set
    if (name == nil) {
        [NSException raise:@"Invalid parameter" format:@"Missing the required parameter `name` when calling `getDocumentStatistics`"];
    }
    

    NSMutableString* resourcePath = [NSMutableString stringWithFormat:@"/words/{name}/statistics"];

    // remove format in URL if needed
    if ([resourcePath rangeOfString:@".{format}"].location != NSNotFound) {
        [resourcePath replaceCharactersInRange: [resourcePath rangeOfString:@".{format}"] withString:@".json"];
    }

    NSMutableDictionary *pathParams = [[NSMutableDictionary alloc] init];
    if (name != nil) {
        pathParams[@"name"] = name;
    }
    

    NSMutableDictionary* queryParams = [[NSMutableDictionary alloc] init];
    if(includeComments != nil) {
        
        queryParams[@"includeComments"] = includeComments;
    }
    if(includeFootnotes != nil) {
        
        queryParams[@"includeFootnotes"] = includeFootnotes;
    }
    if(includeTextInShapes != nil) {
        
        queryParams[@"includeTextInShapes"] = includeTextInShapes;
    }
    if(storage != nil) {
        
        queryParams[@"storage"] = storage;
    }
    if(folder != nil) {
        
        queryParams[@"folder"] = folder;
    }
    
    NSMutableDictionary* headerParams = [NSMutableDictionary dictionaryWithDictionary:self.defaultHeaders];

    

    // HTTP header `Accept`
    headerParams[@"Accept"] = [ASPApiClient selectHeaderAccept:@[@"application/json"]];
    if ([headerParams[@"Accept"] length] == 0) {
        [headerParams removeObjectForKey:@"Accept"];
    }

    // response content type
    NSString *responseContentType;
    if ([headerParams objectForKey:@"Accept"]) {
        responseContentType = [headerParams[@"Accept"] componentsSeparatedByString:@", "][0];
    }
    else {
        responseContentType = @"";
    }

    // request content type
    NSString *requestContentType = [ASPApiClient selectHeaderContentType:@[@"application/json"]];

    // Authentication setting
    NSArray *authSettings = @[];

    id bodyParam = nil;
    NSMutableDictionary *formParams = [[NSMutableDictionary alloc] init];
    NSMutableDictionary *files = [[NSMutableDictionary alloc] init];
    
    
    

    
    return [self.apiClient requestWithCompletionBlock: resourcePath
                                               method: @"GET"
                                           pathParams: pathParams
                                          queryParams: queryParams
                                           formParams: formParams
                                                files: files
                                                 body: bodyParam
                                         headerParams: headerParams
                                         authSettings: authSettings
                                   requestContentType: requestContentType
                                  responseContentType: responseContentType
                                         responseType: @"ASPStatDataResponse*"
                                      completionBlock: ^(id data, NSError *error) {
                  
                  completionBlock((ASPStatDataResponse*)data, error);
              }
          ];
}

///
/// Read document text items.
/// 
///  @param name The document name.
///
///  @param storage Document's storage.
///
///  @param folder Document's folder.
///
///  @returns ASPTextItemsResponse*
///
-(NSNumber*) getDocumentTextItemsWithCompletionBlock: (NSString*) name
         storage: (NSString*) storage
         folder: (NSString*) folder
        
        completionHandler: (void (^)(ASPTextItemsResponse* output, NSError* error))completionBlock { 
        

    
    // verify the required parameter 'name' is set
    if (name == nil) {
        [NSException raise:@"Invalid parameter" format:@"Missing the required parameter `name` when calling `getDocumentTextItems`"];
    }
    

    NSMutableString* resourcePath = [NSMutableString stringWithFormat:@"/words/{name}/textItems"];

    // remove format in URL if needed
    if ([resourcePath rangeOfString:@".{format}"].location != NSNotFound) {
        [resourcePath replaceCharactersInRange: [resourcePath rangeOfString:@".{format}"] withString:@".json"];
    }

    NSMutableDictionary *pathParams = [[NSMutableDictionary alloc] init];
    if (name != nil) {
        pathParams[@"name"] = name;
    }
    

    NSMutableDictionary* queryParams = [[NSMutableDictionary alloc] init];
    if(storage != nil) {
        
        queryParams[@"storage"] = storage;
    }
    if(folder != nil) {
        
        queryParams[@"folder"] = folder;
    }
    
    NSMutableDictionary* headerParams = [NSMutableDictionary dictionaryWithDictionary:self.defaultHeaders];

    

    // HTTP header `Accept`
    headerParams[@"Accept"] = [ASPApiClient selectHeaderAccept:@[@"application/json"]];
    if ([headerParams[@"Accept"] length] == 0) {
        [headerParams removeObjectForKey:@"Accept"];
    }

    // response content type
    NSString *responseContentType;
    if ([headerParams objectForKey:@"Accept"]) {
        responseContentType = [headerParams[@"Accept"] componentsSeparatedByString:@", "][0];
    }
    else {
        responseContentType = @"";
    }

    // request content type
    NSString *requestContentType = [ASPApiClient selectHeaderContentType:@[@"application/json"]];

    // Authentication setting
    NSArray *authSettings = @[];

    id bodyParam = nil;
    NSMutableDictionary *formParams = [[NSMutableDictionary alloc] init];
    NSMutableDictionary *files = [[NSMutableDictionary alloc] init];
    
    
    

    
    return [self.apiClient requestWithCompletionBlock: resourcePath
                                               method: @"GET"
                                           pathParams: pathParams
                                          queryParams: queryParams
                                           formParams: formParams
                                                files: files
                                                 body: bodyParam
                                         headerParams: headerParams
                                         authSettings: authSettings
                                   requestContentType: requestContentType
                                  responseContentType: responseContentType
                                         responseType: @"ASPTextItemsResponse*"
                                      completionBlock: ^(id data, NSError *error) {
                  
                  completionBlock((ASPTextItemsResponse*)data, error);
              }
          ];
}

///
/// Update (reevaluate) fields in document.
/// 
///  @param name The document name.
///
///  @param filename Result name of the document after the operation. If this parameter is omitted then result of the operation will be saved as the source document
///
///  @param storage The document storage.
///
///  @param folder The document folder.
///
///  @returns ASPDocumentResponse*
///
-(NSNumber*) postUpdateDocumentFieldsWithCompletionBlock: (NSString*) name
         filename: (NSString*) filename
         storage: (NSString*) storage
         folder: (NSString*) folder
        
        completionHandler: (void (^)(ASPDocumentResponse* output, NSError* error))completionBlock { 
        

    
    // verify the required parameter 'name' is set
    if (name == nil) {
        [NSException raise:@"Invalid parameter" format:@"Missing the required parameter `name` when calling `postUpdateDocumentFields`"];
    }
    

    NSMutableString* resourcePath = [NSMutableString stringWithFormat:@"/words/{name}/updateFields"];

    // remove format in URL if needed
    if ([resourcePath rangeOfString:@".{format}"].location != NSNotFound) {
        [resourcePath replaceCharactersInRange: [resourcePath rangeOfString:@".{format}"] withString:@".json"];
    }

    NSMutableDictionary *pathParams = [[NSMutableDictionary alloc] init];
    if (name != nil) {
        pathParams[@"name"] = name;
    }
    

    NSMutableDictionary* queryParams = [[NSMutableDictionary alloc] init];
    if(filename != nil) {
        
        queryParams[@"filename"] = filename;
    }
    if(storage != nil) {
        
        queryParams[@"storage"] = storage;
    }
    if(folder != nil) {
        
        queryParams[@"folder"] = folder;
    }
    
    NSMutableDictionary* headerParams = [NSMutableDictionary dictionaryWithDictionary:self.defaultHeaders];

    

    // HTTP header `Accept`
    headerParams[@"Accept"] = [ASPApiClient selectHeaderAccept:@[@"application/json"]];
    if ([headerParams[@"Accept"] length] == 0) {
        [headerParams removeObjectForKey:@"Accept"];
    }

    // response content type
    NSString *responseContentType;
    if ([headerParams objectForKey:@"Accept"]) {
        responseContentType = [headerParams[@"Accept"] componentsSeparatedByString:@", "][0];
    }
    else {
        responseContentType = @"";
    }

    // request content type
    NSString *requestContentType = [ASPApiClient selectHeaderContentType:@[@"application/json"]];

    // Authentication setting
    NSArray *authSettings = @[];

    id bodyParam = nil;
    NSMutableDictionary *formParams = [[NSMutableDictionary alloc] init];
    NSMutableDictionary *files = [[NSMutableDictionary alloc] init];
    
    
    

    
    return [self.apiClient requestWithCompletionBlock: resourcePath
                                               method: @"POST"
                                           pathParams: pathParams
                                          queryParams: queryParams
                                           formParams: formParams
                                                files: files
                                                 body: bodyParam
                                         headerParams: headerParams
                                         authSettings: authSettings
                                   requestContentType: requestContentType
                                  responseContentType: responseContentType
                                         responseType: @"ASPDocumentResponse*"
                                      completionBlock: ^(id data, NSError *error) {
                  
                  completionBlock((ASPDocumentResponse*)data, error);
              }
          ];
}

///
/// Delete watermark (for deleting last watermark from the document).
/// 
///  @param name The document name.
///
///  @param filename Result name of the document after the operation. If this parameter is omitted then result of the operation will be saved as the source document
///
///  @param storage The document storage.
///
///  @param folder The document folder.
///
///  @returns ASPDocumentResponse*
///
-(NSNumber*) deleteDocumentWatermarkWithCompletionBlock: (NSString*) name
         filename: (NSString*) filename
         storage: (NSString*) storage
         folder: (NSString*) folder
        
        completionHandler: (void (^)(ASPDocumentResponse* output, NSError* error))completionBlock { 
        

    
    // verify the required parameter 'name' is set
    if (name == nil) {
        [NSException raise:@"Invalid parameter" format:@"Missing the required parameter `name` when calling `deleteDocumentWatermark`"];
    }
    

    NSMutableString* resourcePath = [NSMutableString stringWithFormat:@"/words/{name}/watermark"];

    // remove format in URL if needed
    if ([resourcePath rangeOfString:@".{format}"].location != NSNotFound) {
        [resourcePath replaceCharactersInRange: [resourcePath rangeOfString:@".{format}"] withString:@".json"];
    }

    NSMutableDictionary *pathParams = [[NSMutableDictionary alloc] init];
    if (name != nil) {
        pathParams[@"name"] = name;
    }
    

    NSMutableDictionary* queryParams = [[NSMutableDictionary alloc] init];
    if(filename != nil) {
        
        queryParams[@"filename"] = filename;
    }
    if(storage != nil) {
        
        queryParams[@"storage"] = storage;
    }
    if(folder != nil) {
        
        queryParams[@"folder"] = folder;
    }
    
    NSMutableDictionary* headerParams = [NSMutableDictionary dictionaryWithDictionary:self.defaultHeaders];

    

    // HTTP header `Accept`
    headerParams[@"Accept"] = [ASPApiClient selectHeaderAccept:@[@"application/json"]];
    if ([headerParams[@"Accept"] length] == 0) {
        [headerParams removeObjectForKey:@"Accept"];
    }

    // response content type
    NSString *responseContentType;
    if ([headerParams objectForKey:@"Accept"]) {
        responseContentType = [headerParams[@"Accept"] componentsSeparatedByString:@", "][0];
    }
    else {
        responseContentType = @"";
    }

    // request content type
    NSString *requestContentType = [ASPApiClient selectHeaderContentType:@[@"application/json"]];

    // Authentication setting
    NSArray *authSettings = @[];

    id bodyParam = nil;
    NSMutableDictionary *formParams = [[NSMutableDictionary alloc] init];
    NSMutableDictionary *files = [[NSMutableDictionary alloc] init];
    
    
    

    
    return [self.apiClient requestWithCompletionBlock: resourcePath
                                               method: @"DELETE"
                                           pathParams: pathParams
                                          queryParams: queryParams
                                           formParams: formParams
                                                files: files
                                                 body: bodyParam
                                         headerParams: headerParams
                                         authSettings: authSettings
                                   requestContentType: requestContentType
                                  responseContentType: responseContentType
                                         responseType: @"ASPDocumentResponse*"
                                      completionBlock: ^(id data, NSError *error) {
                  
                  completionBlock((ASPDocumentResponse*)data, error);
              }
          ];
}

///
/// Insert document watermark image.
/// 
///  @param name The document name.
///
///  @param filename Result name of the document after the operation. If this parameter is omitted then result of the operation will be saved as the source document
///
///  @param rotationAngle The watermark rotation angle.
///
///  @param image The image file server full name. If the name is empty the image is expected in request content.
///
///  @param storage The document storage.
///
///  @param folder The document folder.
///
///  @returns ASPDocumentResponse*
///
-(NSNumber*) postInsertDocumentWatermarkImageWithCompletionBlock: (NSString*) name
         filename: (NSString*) filename
         rotationAngle: (NSNumber*) rotationAngle
         image: (NSString*) image
         storage: (NSString*) storage
         folder: (NSString*) folder
        
        completionHandler: (void (^)(ASPDocumentResponse* output, NSError* error))completionBlock { 
        

    
    // verify the required parameter 'name' is set
    if (name == nil) {
        [NSException raise:@"Invalid parameter" format:@"Missing the required parameter `name` when calling `postInsertDocumentWatermarkImage`"];
    }
    

    NSMutableString* resourcePath = [NSMutableString stringWithFormat:@"/words/{name}/watermark/insertImage"];

    // remove format in URL if needed
    if ([resourcePath rangeOfString:@".{format}"].location != NSNotFound) {
        [resourcePath replaceCharactersInRange: [resourcePath rangeOfString:@".{format}"] withString:@".json"];
    }

    NSMutableDictionary *pathParams = [[NSMutableDictionary alloc] init];
    if (name != nil) {
        pathParams[@"name"] = name;
    }
    

    NSMutableDictionary* queryParams = [[NSMutableDictionary alloc] init];
    if(filename != nil) {
        
        queryParams[@"filename"] = filename;
    }
    if(rotationAngle != nil) {
        
        queryParams[@"rotationAngle"] = rotationAngle;
    }
    if(image != nil) {
        
        queryParams[@"image"] = image;
    }
    if(storage != nil) {
        
        queryParams[@"storage"] = storage;
    }
    if(folder != nil) {
        
        queryParams[@"folder"] = folder;
    }
    
    NSMutableDictionary* headerParams = [NSMutableDictionary dictionaryWithDictionary:self.defaultHeaders];

    

    // HTTP header `Accept`
    headerParams[@"Accept"] = [ASPApiClient selectHeaderAccept:@[@"application/json"]];
    if ([headerParams[@"Accept"] length] == 0) {
        [headerParams removeObjectForKey:@"Accept"];
    }

    // response content type
    NSString *responseContentType;
    if ([headerParams objectForKey:@"Accept"]) {
        responseContentType = [headerParams[@"Accept"] componentsSeparatedByString:@", "][0];
    }
    else {
        responseContentType = @"";
    }

    // request content type
    NSString *requestContentType = [ASPApiClient selectHeaderContentType:@[@"application/json"]];

    // Authentication setting
    NSArray *authSettings = @[];

    id bodyParam = nil;
    NSMutableDictionary *formParams = [[NSMutableDictionary alloc] init];
    NSMutableDictionary *files = [[NSMutableDictionary alloc] init];
    
    
    

    
    return [self.apiClient requestWithCompletionBlock: resourcePath
                                               method: @"POST"
                                           pathParams: pathParams
                                          queryParams: queryParams
                                           formParams: formParams
                                                files: files
                                                 body: bodyParam
                                         headerParams: headerParams
                                         authSettings: authSettings
                                   requestContentType: requestContentType
                                  responseContentType: responseContentType
                                         responseType: @"ASPDocumentResponse*"
                                      completionBlock: ^(id data, NSError *error) {
                  
                  completionBlock((ASPDocumentResponse*)data, error);
              }
          ];
}

///
/// Insert document watermark text.
/// 
///  @param name The document name.
///
///  @param watermarkText {WatermarkText} with the watermark data.If the parameter is provided the query string parameters are ignored.
///
///  @param filename Result name of the document after the operation. If this parameter is omitted then result of the operation will be saved as the source document
///
///  @param text The text to insert.
///
///  @param rotationAngle The text rotation angle.
///
///  @param storage The document storage.
///
///  @param folder The document folder.
///
///  @returns ASPDocumentResponse*
///
-(NSNumber*) postInsertDocumentWatermarkTextWithCompletionBlock: (NSString*) name
         watermarkText: (ASPWatermarkText*) watermarkText
         filename: (NSString*) filename
         text: (NSString*) text
         rotationAngle: (NSNumber*) rotationAngle
         storage: (NSString*) storage
         folder: (NSString*) folder
        
        completionHandler: (void (^)(ASPDocumentResponse* output, NSError* error))completionBlock { 
        

    
    // verify the required parameter 'name' is set
    if (name == nil) {
        [NSException raise:@"Invalid parameter" format:@"Missing the required parameter `name` when calling `postInsertDocumentWatermarkText`"];
    }
    
    // verify the required parameter 'watermarkText' is set
    if (watermarkText == nil) {
        [NSException raise:@"Invalid parameter" format:@"Missing the required parameter `watermarkText` when calling `postInsertDocumentWatermarkText`"];
    }
    

    NSMutableString* resourcePath = [NSMutableString stringWithFormat:@"/words/{name}/watermark/insertText"];

    // remove format in URL if needed
    if ([resourcePath rangeOfString:@".{format}"].location != NSNotFound) {
        [resourcePath replaceCharactersInRange: [resourcePath rangeOfString:@".{format}"] withString:@".json"];
    }

    NSMutableDictionary *pathParams = [[NSMutableDictionary alloc] init];
    if (name != nil) {
        pathParams[@"name"] = name;
    }
    

    NSMutableDictionary* queryParams = [[NSMutableDictionary alloc] init];
    if(filename != nil) {
        
        queryParams[@"filename"] = filename;
    }
    if(text != nil) {
        
        queryParams[@"text"] = text;
    }
    if(rotationAngle != nil) {
        
        queryParams[@"rotationAngle"] = rotationAngle;
    }
    if(storage != nil) {
        
        queryParams[@"storage"] = storage;
    }
    if(folder != nil) {
        
        queryParams[@"folder"] = folder;
    }
    
    NSMutableDictionary* headerParams = [NSMutableDictionary dictionaryWithDictionary:self.defaultHeaders];

    

    // HTTP header `Accept`
    headerParams[@"Accept"] = [ASPApiClient selectHeaderAccept:@[@"application/json"]];
    if ([headerParams[@"Accept"] length] == 0) {
        [headerParams removeObjectForKey:@"Accept"];
    }

    // response content type
    NSString *responseContentType;
    if ([headerParams objectForKey:@"Accept"]) {
        responseContentType = [headerParams[@"Accept"] componentsSeparatedByString:@", "][0];
    }
    else {
        responseContentType = @"";
    }

    // request content type
    NSString *requestContentType = [ASPApiClient selectHeaderContentType:@[@"application/json"]];

    // Authentication setting
    NSArray *authSettings = @[];

    id bodyParam = nil;
    NSMutableDictionary *formParams = [[NSMutableDictionary alloc] init];
    NSMutableDictionary *files = [[NSMutableDictionary alloc] init];
    
    bodyParam = watermarkText;
    

    
    return [self.apiClient requestWithCompletionBlock: resourcePath
                                               method: @"POST"
                                           pathParams: pathParams
                                          queryParams: queryParams
                                           formParams: formParams
                                                files: files
                                                 body: bodyParam
                                         headerParams: headerParams
                                         authSettings: authSettings
                                   requestContentType: requestContentType
                                  responseContentType: responseContentType
                                         responseType: @"ASPDocumentResponse*"
                                      completionBlock: ^(id data, NSError *error) {
                  
                  completionBlock((ASPDocumentResponse*)data, error);
              }
          ];
}



@end
