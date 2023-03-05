namespace hdungx99.Movies.API
{
    public static class AppBuilder
    {
        public static void UseBuilder(this IApplicationBuilder builder, bool isDev)
        {
            if (isDev)
            {
                builder.UseSwagger();
                builder.UseSwaggerUI();
            }

            builder.UseHttpsRedirection();

            builder.UseAuthorization();
        }
    }
}
