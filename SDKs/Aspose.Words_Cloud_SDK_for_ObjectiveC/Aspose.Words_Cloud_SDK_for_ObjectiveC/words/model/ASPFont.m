#import "ASPFont.h"

@implementation ASPFont

/**
 * Maps json key to property name.
 * This method is used by `JSONModel`.
 */
+ (JSONKeyMapper *)keyMapper
{
  return [[JSONKeyMapper alloc] initWithDictionary:@{ @"AllCaps": @"allCaps", @"Bidi": @"bidi", @"Bold": @"bold", @"BoldBi": @"boldBi", @"Border": @"border", @"Color": @"color", @"ComplexScript": @"complexScript", @"DoubleStrikeThrough": @"doubleStrikeThrough", @"Emboss": @"emboss", @"Engrave": @"engrave", @"Hidden": @"hidden", @"HighlightColor": @"highlightColor", @"Italic": @"italic", @"ItalicBi": @"italicBi", @"Kerning": @"kerning", @"LocaleId": @"localeId", @"LocaleIdBi": @"localeIdBi", @"LocaleIdFarEast": @"localeIdFarEast", @"Name": @"name", @"NameAscii": @"nameAscii", @"NameBi": @"nameBi", @"NameFarEast": @"nameFarEast", @"NameOther": @"nameOther", @"NoProofing": @"noProofing", @"Outline": @"outline", @"Position": @"position", @"Scaling": @"scaling", @"Shadow": @"shadow", @"Size": @"size", @"SizeBi": @"sizeBi", @"SmallCaps": @"smallCaps", @"Spacing": @"spacing", @"StrikeThrough": @"strikeThrough", @"StyleIdentifier": @"styleIdentifier", @"StyleName": @"styleName", @"Subscript": @"subscript", @"Superscript": @"superscript", @"TextEffect": @"textEffect", @"Underline": @"underline", @"UnderlineColor": @"underlineColor", @"link": @"link" }];
}

/**
 * Indicates whether the property with the given name is optional.
 * If `propertyName` is optional, then return `YES`, otherwise return `NO`.
 * This method is used by `JSONModel`.
 */
+ (BOOL)propertyIsOptional:(NSString *)propertyName
{
  NSArray *optionalProperties = @[@"allCaps", @"bidi", @"bold", @"boldBi", @"border", @"color", @"complexScript", @"doubleStrikeThrough", @"emboss", @"engrave", @"hidden", @"highlightColor", @"italic", @"italicBi", @"kerning", @"localeId", @"localeIdBi", @"localeIdFarEast", @"name", @"nameAscii", @"nameBi", @"nameFarEast", @"nameOther", @"noProofing", @"outline", @"position", @"scaling", @"shadow", @"size", @"sizeBi", @"smallCaps", @"spacing", @"strikeThrough", @"styleIdentifier", @"styleName", @"subscript", @"superscript", @"textEffect", @"underline", @"underlineColor", @"link"];

  if ([optionalProperties containsObject:propertyName]) {
    return YES;
  }
  else {
    return NO;
  }
}

/**
 * Gets the string presentation of the object.
 * This method will be called when logging model object using `NSLog`.
 */
- (NSString *)description {
    return [[self toDictionary] description];
}

@end
