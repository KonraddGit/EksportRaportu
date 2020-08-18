<xsl:stylesheet xmlns:xsl="http://www.w3.org/1999/XSL/Transform" version="1.0">
<xsl:template match="ProducedCar">
  <HTML>
    <BODY>
      <TABLE BORDER="2">
        <TR>
          <TD>VIN</TD>
          <TD>ProductionYear</TD>
          <TD>Model</TD>
        </TR>
        <xsl:apply-templates select="Car"/>
      </TABLE>
    </BODY>
  </HTML>
</xsl:template>
<xsl:template match="Car">
  <TR>
    <TD><xsl:value-of select="VIN"/></TD>
    <TD><xsl:value-of select="ProductionYear"/></TD>
    <TD><xsl:value-of select="Model"/></TD>
  </TR>
</xsl:template>
</xsl:stylesheet>