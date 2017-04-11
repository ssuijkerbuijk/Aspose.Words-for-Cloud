# sepcify App SID
AsposeApp.app_sid = "******************"
# sepcify App Key
AsposeApp.app_key = "******************"
# specify product URI
Product.base_product_uri = 'http://api.aspose.com/v1.1'

# set parameters
file_name = "Bookmarks.docx"
bookmark_name = "first_bookmark"

#build URI to update bookmark text
str_uri_request = Product.base_product_uri + "/words/" + file_name + "/bookmarks/" + bookmark_name

signed_uri = Utils.sign(Utils(),str_uri_request)

post_data = {"Text" : "This is updated text two"}
json_arr = json.dumps(post_data)

response_stream = Utils.process_command(Utils(),signed_uri, "POST", "JSON", json_arr)
json_data = json.loads(response_stream)

if (json_data['Code'] == 200):
    print 'The bookmark text has been updated successfully'
else:
    print 'Error'
