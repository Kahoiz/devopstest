export default [
  {
    ignores: ["node_modules/", "dist/"], // Ignore common folders
  },
  {
    languageOptions: {
      ecmaVersion: "latest", // Use the latest ECMAScript features
      sourceType: "module",  // Enable ES Modules (import/export)
    },
    rules: {
      "no-unused-vars": "warn",  // Warn on unused variables
      "no-console": "off",       // Allow console logs
      "semi": ["error", "always"], // Enforce semicolons
      "quotes": ["error", "double"] // Enforce double quotes
    }
  }
];
