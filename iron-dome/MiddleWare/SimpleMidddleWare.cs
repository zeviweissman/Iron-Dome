namespace iron_dome.MiddleWare
{
    public class SimpleMidddleWare(RequestDelegate next)
    {
        private readonly RequestDelegate _next = next;
        public async Task InvokeAsync(HttpContext context)
        {
            var req = context.Request;
            Console.WriteLine(req.Path.ToString());
            await _next(context);
            var res = context.Response;
            Console.WriteLine(res.StatusCode.ToString());
        }
    }
}






