# Post
[Creating a Docker Container Running ASP.NET Core Web Application Powered by React and Redux](http://jaliyaudagedara.blogspot.com/2017/06/creating-docker-container-running.html)

# Download the sample
```
git init
git remote add -f origin https://github.com/jaliyaudagedara/Blog-Post-Samples.git
git config core.sparseCheckout true
echo "ReactReduxApp/*" >> .git/info/sparse-checkout
git pull origin master
```

# Steps
1. dotnet restore
2. dotnet publish -c Release
3. docker build -t {sometag} .
4. docker run -it --rm -p 30000:80 {sometag}