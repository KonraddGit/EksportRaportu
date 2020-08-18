<xsl:stylesheet xmlns:xsl="http://www.w3.org/1999/XSL/Transform" version="1.0">
<xsl:template match="Car">
<xsl:value-of select="@VIN"/>, <xsl:value-of select="ProductionYear"/>, <xsl:value-of select="Model"/>
</xsl:template>
</xsl:stylesheet>