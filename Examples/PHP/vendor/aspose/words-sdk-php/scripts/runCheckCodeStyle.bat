docker run -v %cd%/:/app -w="/app" --rm php -dmemory_limit=1G ./vendor/bin/phpcs --report-file=testReports/codeStyleErrors ./src