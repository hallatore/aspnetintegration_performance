# aspnetintegration performance benchmark

```
// Kestrel
wrk -t1 -c1 http://localhost:5000
Running 10s test @ http://localhost:5000
  1 threads and 1 connections
  Thread Stats   Avg      Stdev     Max   +/- Stdev
    Latency   463.31us  623.16us   6.47ms   79.63%
    Req/Sec     9.85k   307.45    10.23k    73.00%
  98072 requests in 10.00s, 36.29MB read
Requests/sec:   9806.82
Transfer/sec:      3.63MB

// IIS+Kestrel
wrk -t1 -c1 http://localhost:5001
Running 10s test @ http://localhost:5001
  1 threads and 1 connections
  Thread Stats   Avg      Stdev     Max   +/- Stdev
    Latency   551.70us  670.83us   6.00ms   76.87%
    Req/Sec     3.89k   119.71     4.11k    58.42%
  39045 requests in 10.10s, 15.32MB read
Requests/sec:   3865.94
Transfer/sec:      1.52MB
```
