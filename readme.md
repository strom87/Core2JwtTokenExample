# Dotnet core 2.1 jwt token authenitcation example
### User credentials
    - username: bob
    - password: asd123

### Test it out

Try to do a GET request route to the route
```
Route: GET - /api/protected
```
This will give you an HTTP 401 - Unauthorized
You need to have a BEARER TOKEN an pass it in the request header to be able to do a request against the protected route.

Do a POST request to the public login route
```
Route: POST - /api/public
{
    "username": "bob",
    "password": "asd123"
}
```
This will give you the a token back in the respone.
Use this token in the header of the request against the protected route.

Create a new GET request against the protected route
```
Route: GET - /api/protected
Header: Authorization Bearer {PASTE_TOKEN_HERE}
$ curl -H "Authorization: Bearer INSERT_TOKEN" http://domain/api/protected
```