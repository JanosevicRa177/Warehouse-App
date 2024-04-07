package myplugin.generator.options;

public class PluralUtil {
    public static String translateToPlural(String singular) {
        if (singular == null || singular.isEmpty()) {
            throw new IllegalArgumentException("Input string cannot be null or empty");
        }

        String lowerCaseSingular = singular.toLowerCase();
        
        // Handle regular pluralization rules
        if (lowerCaseSingular.endsWith("s") || lowerCaseSingular.endsWith("x") || 
            lowerCaseSingular.endsWith("z") || lowerCaseSingular.endsWith("ch") || 
            lowerCaseSingular.endsWith("sh")) {
            return singular + "es";
        } else if (lowerCaseSingular.endsWith("y") && !isVowel(lowerCaseSingular.charAt(lowerCaseSingular.length() - 2))) {
            return singular.substring(0, singular.length() - 1) + "ies";
        } else {
            return singular + "s";
        }
    }

    private static boolean isVowel(char c) {
        return "aeiou".indexOf(c) != -1;
    }
}