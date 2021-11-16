<?xml version="1.0" encoding="utf-8"?>
<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform">
	<xsl:output method="html">
	</xsl:output>
	<xsl:template match="/">
		<html>
			<body>
				<table border="1">
					<tr>
						<th>Name</th>
						<th>Artist</th>
						<th>Album</th>
						<th>Genre</th>
						<th>Year</th>
						<th>Label</th>
					</tr>
					<xsl:for-each select="songs/song">
						<tr>
							<td>
								<xsl:value-of select="@Name">
								</xsl:value-of>
							</td>
							<td>
								<xsl:value-of select="@Artist">
								</xsl:value-of>
							</td>
							<td>
								<xsl:value-of select="@Album">
								</xsl:value-of>
							</td>
							<td>
								<xsl:value-of select="@Genre">
								</xsl:value-of>
							</td>
							<td>
								<xsl:value-of select="@Year">
								</xsl:value-of>
							</td>
							<td>
								<xsl:value-of select="@Label">
								</xsl:value-of>
							</td>
						</tr>
					</xsl:for-each>
				</table>
			</body>
		</html>
	</xsl:template>
</xsl:stylesheet>